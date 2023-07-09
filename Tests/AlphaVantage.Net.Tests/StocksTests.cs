using Xunit;

namespace AlphaVantage.Tests;

public class StocksTests : IClassFixture<AlphaVantageFixture>
{
	private readonly AlphaVantageFixture _fixture;

	public StocksTests(AlphaVantageFixture fixture)
	{
		_fixture = fixture;
	}

	[Fact]
	public async Task VerifyIntradayTimeSeries() =>
		// all we're looking for is successful api query
		await _fixture.Client.GetIntradayTimeSeries(
			new()
			{
				Symbol = "IBM",
				Interval = Stocks.TimeSeriesInterval.SixtyMinutes,
			});

	[Fact]
	public async Task VerifyDailyTimeSeriesDefault() =>
		// all we're looking for is successful api query
		await _fixture.Client.GetDailyTimeSeries(
			new()
			{
				Symbol = "IBM",
			});

	[Fact]
	public async Task VerifyDailyTimeSeriesOutputSize() =>
		// all we're looking for is successful api query
		await _fixture.Client.GetDailyTimeSeries(
			new()
			{
				Symbol = "IBM",
				OutputSize = Stocks.TimeSeriesOutputSize.Full,
			});

	[Fact]
	public async Task VerifyDailyAdjustedTimeSeriesDefault() =>
		// all we're looking for is successful api query
		await _fixture.Client.GetDailyAdjustedTimeSeries(
			new()
			{
				Symbol = "IBM",
			});

	[Fact]
	public async Task VerifyDailyAdjustedTimeSeriesOutputSize() =>
		// all we're looking for is successful api query
		await _fixture.Client.GetDailyAdjustedTimeSeries(
			new()
			{
				Symbol = "IBM",
				OutputSize = Stocks.TimeSeriesOutputSize.Full,
			});

	[Fact]
	public async Task VerifyWeeklyTimeSeries() =>
		// all we're looking for is successful api query
		await _fixture.Client.GetWeeklyTimeSeries(
			new()
			{
				Symbol = "IBM",
			});

	[Fact]
	public async Task VerifyWeeklyAdjustedTimeSeries() =>
		// all we're looking for is successful api query
		await _fixture.Client.GetWeeklyAdjustedTimeSeries(
			new()
			{
				Symbol = "IBM",
			});

	[Fact]
	public async Task VerifyMonthlyTimeSeries() =>
		// all we're looking for is successful api query
		await _fixture.Client.GetMonthlyTimeSeries(
			new()
			{
				Symbol = "IBM",
			});

	[Fact]
	public async Task VerifyMonthlyAdjustedTimeSeries() =>
		// all we're looking for is successful api query
		await _fixture.Client.GetMonthlyAdjustedTimeSeries(
			new()
			{
				Symbol = "IBM",
			});

	[Fact]
	public async Task VerifyQuote() =>
		// all we're looking for is successful api query
		await _fixture.Client.GetQuote(
			new()
			{
				Symbol = "IBM",
			});

	[Fact]
	public async Task VerifySymbolSearch() =>
		// all we're looking for is successful api query
		await _fixture.Client.SearchSymbols(
			new()
			{
				Keyword = "IBM",
			});

	[Fact]
	public async Task VerifyGetMarketStatus() =>
		// all we're looking for is successful api query
		await _fixture.Client.GetMarketStatus(new());
}
