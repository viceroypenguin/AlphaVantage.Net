using Xunit;

namespace AlphaVantage.Tests;

public sealed class IndicatorsTests : IClassFixture<AlphaVantageFixture>
{
	private readonly AlphaVantageFixture _fixture;

	public IndicatorsTests(AlphaVantageFixture fixture)
	{
		_fixture = fixture;
	}

	[Fact]
	public async Task VerifyRealGdp() =>
		// all we're looking for is successful api query
		await _fixture.Client.GetRealGdp(
			new()
			{
				Interval = Indicators.GdpInterval.Quarterly
			});

	[Fact]
	public async Task VerifyRealGdpPerCapita() =>
		// all we're looking for is successful api query
		await _fixture.Client.GetRealGdpPerCapita(
			new()
			{
			});
}
