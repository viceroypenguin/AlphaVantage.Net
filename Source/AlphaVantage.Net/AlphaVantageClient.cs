using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Text.Json.Serialization;
using CommunityToolkit.Diagnostics;
using CsvHelper;
using Microsoft.Extensions.Logging.Abstractions;

namespace AlphaVantage;

/// <summary>
/// A class that provides methods for querying data from the Alpha Vantage API.
/// </summary>
/// <remarks>
/// This class is designed to be short-lived and transient, as a unit-of-work class.
/// </remarks>
[SuppressMessage("Design", "CA1001:Types that own disposable fields should be disposable", Justification = "_rateLimiter has a longer scope than AlphaVantageClient.")]
public sealed partial class AlphaVantageClient
{
	private readonly RateLimiter _rateLimiter;
	private readonly IAlphaVantageApi _alphaVantageApi;
	private readonly string _apiKey;

	internal AlphaVantageClient(
		RateLimiter rateLimiter,
		IAlphaVantageApi alphaVantageApi,
		IOptions<AlphaVantageOptions> options
	)
	{
		Guard.IsNotNull(options?.Value?.ApiKey);

		_rateLimiter = rateLimiter;
		_alphaVantageApi = alphaVantageApi;
		_apiKey = options.Value.ApiKey;
	}

	/// <summary>
	/// Create a new <see cref="AlphaVantageClient"/> with the specified API key and rate limit.
	/// </summary>
	/// <param name="apiKey">The API key provided by AlphaVantage.co for access to their APIs.</param>
	/// <param name="maxCallsPerMinute">The Rate Limit set for the provided API key.</param>
	/// <remarks>
	/// This constructor should only be used by short-lived console applications. The rate-limiting provided by this
	/// instance is not shared with any other instance. This can cause issues with calling Alpha Vantage in excess of
	/// allowed API rate limits.
	/// </remarks>
	[SuppressMessage("Design", "CA2000:Dispose objects before losing scope", Justification = "HttpClient won't be disposed.")]
	[SuppressMessage("Design", "CA5399:HttpClient is created without enabling CheckCertificateRevocationList", Justification = "Unnecessary check for AlphaVantage.")]
	public AlphaVantageClient(
		string apiKey,
		int maxCallsPerMinute
	)
	{
		Guard.IsNotNull(apiKey, nameof(apiKey));

		_rateLimiter = new RateLimiter(maxCallsPerMinute);
		_alphaVantageApi = RestService.For<IAlphaVantageApi>(
			new HttpClient(
				new HttpClientHandler
				{
					AutomaticDecompression = System.Net.DecompressionMethods.All,
				})
			{
				BaseAddress = new Uri("https://www.alphavantage.co/"),
			},
			settings: new()
			{
				ContentSerializer = new SystemTextJsonContentSerializer(JsonSerializerOptions),
				UrlParameterFormatter = new UrlParameterFormatter(),
			}
		);
		_apiKey = apiKey;
	}

	/// <summary>
	/// The configured maximum number of api calls to make per minute.
	/// </summary>
	public int MaxApiCallsPerMinute => _rateLimiter.MaxCallsPerMinute;

	internal static readonly JsonSerializerOptions JsonSerializerOptions =
		new()
		{
			DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
			PropertyNameCaseInsensitive = true,
			NumberHandling = JsonNumberHandling.AllowReadingFromString,
			Converters =
			{
				new InvalidDateOnlyConverter(),
				new InvalidDecimalConverter(),
				new EnumConverterFactory(),
			},
		};

	private async Task<TResponse> WrapJsonCall<TResponse>(Func<Task<TResponse>> apiCall, CancellationToken cancellationToken)
	{
		using var lease = await _rateLimiter.AcquireAsync(cancellationToken).ConfigureAwait(false);
		if (!lease.IsAcquired)
			ThrowHelper.ThrowTimeoutException();

		return await apiCall().ConfigureAwait(false);
	}

	private async Task<IReadOnlyList<TResponse>> WrapCsvCall<TResponse>(Func<Task<Stream>> apiCall, CancellationToken cancellationToken)
	{
		using var lease = await _rateLimiter.AcquireAsync(cancellationToken).ConfigureAwait(false);
		if (!lease.IsAcquired)
			ThrowHelper.ThrowTimeoutException();

		using var stream = await apiCall().ConfigureAwait(false);
		using var reader = new StreamReader(stream);

		if (reader.Peek() == '{')
		{
			var str = await reader.ReadToEndAsync(
#if NET7_0_OR_GREATER
				cancellationToken
#endif
			).ConfigureAwait(false);

			var json = JsonSerializer.Deserialize<JsonElement>(str);
			var error = json.GetProperty("Error Message").GetString()!;
			throw new AlphaVantageException(error, str);
		}

		using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

		var list = new List<TResponse>();
		await foreach (var i in csv.GetRecordsAsync<TResponse>(cancellationToken).ConfigureAwait(false))
			list.Add(i);
		return list;
	}
}
