using AlphaVantage;
using CommunityToolkit.Diagnostics;

namespace Microsoft.Extensions.DependencyInjection;

/// <summary>
/// Holding class for extension methods.
/// </summary>
public static class AlphaVantageServiceCollectionExtensions
{
	/// <summary>
	/// Registers the <see cref="AlphaVantageClient"/> infrastructure, using the data in the <c>AlphaVantageOptions</c>
	/// section of the system configuration.
	/// </summary>
	/// <param name="services">The <see cref="IServiceCollection"/> to add the services to</param>
	/// <returns>The <see cref="IServiceCollection"/> so that additional calls can be chained</returns>
	/// <remarks>
	/// <para>Extracts configuration from the section titled <c>AlphaVantageOptions</c></para>
	/// </remarks>
	public static IServiceCollection AddAlphaVantageClient(this IServiceCollection services) =>
		services.AddAlphaVantageClient(nameof(AlphaVantageOptions));

	/// <summary>
	/// Registers the <see cref="AlphaVantageClient"/> infrastructure, using the data in the <paramref name="sectionPath"/>
	/// section of the system configuration.
	/// </summary>
	/// <param name="services">The <see cref="IServiceCollection"/> to add the services to</param>
	/// <param name="sectionPath">The path to the </param>
	/// <returns>The <see cref="IServiceCollection"/> so that additional calls can be chained</returns>
	public static IServiceCollection AddAlphaVantageClient(
		this IServiceCollection services,
		string sectionPath)
	{
		Guard.IsNotNull(services);
		Guard.IsNotNull(sectionPath);

		_ = services
			.AddOptions<AlphaVantageOptions>()
			.BindConfiguration(sectionPath);
		services.DoAddAlphaVantageClient();

		return services;
	}

	/// <summary>
	/// Registers the <see cref="AlphaVantageClient"/> infrastructure, using the data in the provided <see
	/// cref="IConfiguration"/> configuration section.
	/// </summary>
	/// <param name="services">The <see cref="IServiceCollection"/> to add the services to</param>
	/// <param name="configureOptions">The action used to configure the options</param>
	/// <returns>The <see cref="IServiceCollection"/> so that additional calls can be chained</returns>
	public static IServiceCollection AddAlphaVantageClient(
		this IServiceCollection services,
		Action<AlphaVantageOptions> configureOptions)
	{
		Guard.IsNotNull(services);
		Guard.IsNotNull(configureOptions);

		_ = services.Configure(configureOptions);
		services.DoAddAlphaVantageClient();

		return services;
	}

	private static void DoAddAlphaVantageClient(this IServiceCollection services)
	{
		_ = services.PostConfigure<AlphaVantageOptions>(o =>
		{
			Guard.IsNotNull(o.ApiKey, "AlphaVantage ApiKey");
			Guard.IsGreaterThan(o.MaxApiCallsPerMinute, 0, "AlphaVantage MaxApiCallsPerMinute");
		});

		_ = services.AddSingleton(sp =>
			new AlphaVantageClient.RateLimiter(
				sp.GetRequiredService<IOptions<AlphaVantageOptions>>().Value.MaxApiCallsPerMinute));
		_ = services
			.AddRefitClient<IAlphaVantageApi>(settings: new()
			{
				ContentSerializer = new SystemTextJsonContentSerializer(AlphaVantageClient.JsonSerializerOptions),
				UrlParameterFormatter = new UrlParameterFormatter(),
			})
			.ConfigureHttpClient(c => c.BaseAddress = new Uri("https://www.alphavantage.co/"))
			.ConfigurePrimaryHttpMessageHandler(() =>
				new HttpClientHandler { AutomaticDecompression = System.Net.DecompressionMethods.All, });
		_ = services.AddTransient(sp =>
			new AlphaVantageClient(
				sp.GetRequiredService<AlphaVantageClient.RateLimiter>(),
				sp.GetRequiredService<IAlphaVantageApi>(),
				sp.GetRequiredService<IOptions<AlphaVantageOptions>>(),
				sp.GetService<ILogger<AlphaVantageClient>>()));
	}
}
