using AlphaVantage;
using CommunityToolkit.Diagnostics;

namespace Microsoft.Extensions.DependencyInjection;

/// <summary>
/// Holding class for extension methods.
/// </summary>
public static class AlphaVantageServiceCollectionExtensions
{
	/// <summary>
	/// Registers the <see cref="AlphaVantageClient"/> infrastructure, including <see cref="AlphaVantageClient"/>
	/// configuration data stored in the <see cref="AlphaVantageOptions.SectionKey"/> (<c>"AlphaVantage"</c>) section of
	/// the provided configuration root.
	/// </summary>
	/// <param name="services">The <see cref="IServiceCollection"/> to add the services to</param>
	/// <param name="configuration">The configuration root that holds a <c>"AlphaVantage"</c> section of configuration
	/// data for AlphaVantage</param>
	/// <returns>The <see cref="IServiceCollection"/> so that additional calls can be chained</returns>
	public static IServiceCollection AddAlphaVantageClient(
		this IServiceCollection services,
		IConfigurationRoot configuration)
	{
		Guard.IsNotNull(services);
		Guard.IsNotNull(configuration);

		services.Configure<AlphaVantageOptions>(
			configuration.GetSection(AlphaVantageOptions.SectionKey));
		services.AddSingleton(sp =>
			new AlphaVantageClient.RateLimiter(
				sp.GetRequiredService<IOptions<AlphaVantageOptions>>().Value.MaxApiCallsPerMinute));
		services
			.AddRefitClient<IAlphaVantageApi>(settings: new()
			{
				ContentSerializer = new SystemTextJsonContentSerializer(AlphaVantageClient.JsonSerializerOptions),
			})
			.ConfigureHttpClient(c => c.BaseAddress = new Uri("https://www.alphavantage.co/"))
			.ConfigurePrimaryHttpMessageHandler(() =>
				new HttpClientHandler { AutomaticDecompression = System.Net.DecompressionMethods.All, });
		services.AddTransient(sp =>
			new AlphaVantageClient(
				sp.GetRequiredService<AlphaVantageClient.RateLimiter>(),
				sp.GetRequiredService<IAlphaVantageApi>(),
				sp.GetRequiredService<IOptions<AlphaVantageOptions>>(),
				sp.GetService<ILogger<AlphaVantageClient>>()));

		return services;
	}
}
