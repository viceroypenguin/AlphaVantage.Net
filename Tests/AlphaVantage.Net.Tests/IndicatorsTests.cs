using Xunit;

namespace AlphaVantage.Tests;

public sealed class IndicatorsTests(AlphaVantageFixture fixture) : IClassFixture<AlphaVantageFixture>
{
	private readonly AlphaVantageFixture _fixture = fixture;

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
			new());

	[Fact]
	public async Task VerifyTreasuryYield() =>
		// all we're looking for is successful api query
		await _fixture.Client.GetTreasuryYield(
			new()
			{
				Interval = Indicators.TreasuryYieldInterval.Monthly,
				Maturity = Indicators.TreasuryYieldMaturity.TenYear,
			});

	[Fact]
	public async Task VerifyFederalFundsRate() =>
		// all we're looking for is successful api query
		await _fixture.Client.GetFederalFundsRate(
			new()
			{
				Interval = Indicators.FederalFundsRateInterval.Monthly,
			});

	[Fact]
	public async Task VerifyCpi() =>
		// all we're looking for is successful api query
		await _fixture.Client.GetCpi(
			new()
			{
				Interval = Indicators.CpiInterval.SemiAnnual
			});

	[Fact]
	public async Task VerifyInflation() =>
		// all we're looking for is successful api query
		await _fixture.Client.GetInflation(
			new());

	[Fact]
	public async Task VerifyRetailSales() =>
		// all we're looking for is successful api query
		await _fixture.Client.GetRetailSales(
			new());

	[Fact]
	public async Task VerifyDurables() =>
		// all we're looking for is successful api query
		await _fixture.Client.GetDurables(
			new());

	[Fact]
	public async Task VerifyUnemployment() =>
		// all we're looking for is successful api query
		await _fixture.Client.GetUnemployment(
			new());

	[Fact]
	public async Task VerifyNonfarmPayroll() =>
		// all we're looking for is successful api query
		await _fixture.Client.GetNonfarmPayroll(
			new());
}
