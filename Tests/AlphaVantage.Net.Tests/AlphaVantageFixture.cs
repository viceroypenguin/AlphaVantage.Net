using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AlphaVantage.Tests;

public sealed class AlphaVantageFixture
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
