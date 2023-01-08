using CommunityToolkit.Diagnostics;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Extensions.Options;
using Refit;

namespace AlphaVantage;

/// <summary>
/// A class that provides methods for querying data from the Alpha Vantage API.
/// </summary>
/// <remarks>
/// This class is designed to be short-lived and transient, as a unit-of-work class.
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1001:Types that own disposable fields should be disposable", Justification = "_rateLimiter has a longer scope than AlphaVantageClient.")]
public sealed partial class AlphaVantageClient
{
	private readonly RateLimiter _rateLimiter;
	private readonly IAlphaVantageApi _alphaVantageApi;
	private readonly string _apiKey;
	private readonly ILogger<AlphaVantageClient>? _logger;

	internal AlphaVantageClient(
		RateLimiter rateLimiter,
		IAlphaVantageApi alphaVantageApi,
		IOptions<AlphaVantageOptions> options,
		ILogger<AlphaVantageClient>? logger = null)
	{
		Guard.IsNotNull(options?.Value?.ApiKey);

		_rateLimiter = rateLimiter;
		_alphaVantageApi = alphaVantageApi;
		_apiKey = options.Value.ApiKey;
		_logger = logger ?? NullLogger<AlphaVantageClient>.Instance;
	}

	/// <summary>
	/// Create a new <see cref="AlphaVantageClient"/> with the specified API key and rate limit.
	/// </summary>
	/// <param name="apiKey">The API key provided by AlphaVantage.co for access to their APIs.</param>
	/// <param name="maxCallsPerMinute">The Rate Limit set for the provided API key.</param>
	/// <param name="logger">A logger used to log information about API calls, if provided.</param>
	/// <remarks>
	/// This constructor should only be used by short-lived console applications. The rate-limiting provided by this
	/// instance is not shared with any other instance. This can cause issues with calling Alpha Vantage in excess of
	/// allowed API rate limits.
	/// </remarks>
	public AlphaVantageClient(
		string apiKey,
		int maxCallsPerMinute,
		ILogger<AlphaVantageClient>? logger = null)
	{
		Guard.IsNotNull(apiKey, nameof(apiKey));

		_rateLimiter = new RateLimiter(maxCallsPerMinute);
		_alphaVantageApi = RestService.For<IAlphaVantageApi>("https://www.alphavantage.co/");
		_apiKey = apiKey;
		_logger = logger ?? NullLogger<AlphaVantageClient>.Instance;
	}
}
