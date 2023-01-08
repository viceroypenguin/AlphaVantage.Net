using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AlphaVantage.Tests;

public class AlphaVantageFixture
{
	private readonly ServiceProvider _serviceProvider;

	public AlphaVantageClient Client { get; }

	public AlphaVantageFixture()
	{
		var configuration = new ConfigurationBuilder()
			.AddJsonFile("secrets.json", optional: true)
			.AddEnvironmentVariables()
			.Build();

		var services = new ServiceCollection();
		services.AddAlphaVantageClient(configuration);

		_serviceProvider = services.BuildServiceProvider();
		Client = _serviceProvider.GetRequiredService<AlphaVantageClient>();
	}
}
