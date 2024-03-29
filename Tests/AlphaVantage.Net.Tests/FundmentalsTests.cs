using Xunit;

namespace AlphaVantage.Tests;

public sealed class FundmentalsTests(AlphaVantageFixture fixture) : IClassFixture<AlphaVantageFixture>
{
	private readonly AlphaVantageFixture _fixture = fixture;

	[Fact]
	public async Task VerifyCompanySummary() =>
		// all we're looking for is successful api query
		await _fixture.Client.GetCompanySummary(
			new()
			{
				Symbol = "IBM",
			});

	[Fact]
	public async Task VerifyIncomeStatement() =>
		// all we're looking for is successful api query
		await _fixture.Client.GetIncomeStatement(
			new()
			{
				Symbol = "IBM",
			});

	[Fact]
	public async Task VerifyBalanceSheet() =>
		// all we're looking for is successful api query
		await _fixture.Client.GetBalanceSheet(
			new()
			{
				Symbol = "IBM",
			});

	[Fact]
	public async Task VerifyCashFlow() =>
		// all we're looking for is successful api query
		await _fixture.Client.GetCashFlow(
			new()
			{
				Symbol = "IBM",
			});

	[Fact]
	public async Task VerifyEarnings() =>
		// all we're looking for is successful api query
		await _fixture.Client.GetEarnings(
			new()
			{
				Symbol = "IBM",
			});

	[Fact]
	public async Task VerifyListingStatusDefault() =>
		// all we're looking for is successful api query
		await _fixture.Client.GetListingStatus(new());

	[Fact]
	public async Task VerifyListingStatusParameters() =>
		// all we're looking for is successful api query
		await _fixture.Client.GetListingStatus(
			new()
			{
				Date = new DateOnly(2022, 01, 01),
				State = Fundamentals.ListingStatus.Delisted,
			});

	[Fact]
	public async Task VerifyEarningsCalendarDefault() =>
		// all we're looking for is successful api query
		await _fixture.Client.GetEarningsCalendar(new());

	[Fact]
	public async Task VerifyEarningsCalendarParameters() =>
		// all we're looking for is successful api query
		await _fixture.Client.GetEarningsCalendar(
			new()
			{
				Horizon = Fundamentals.EarningsCalendarHorizon.TwelveMonths,
				Symbol = "IBM",
			});

	[Fact]
	public async Task VerifyIpoCalendar() =>
		// all we're looking for is successful api query
		await _fixture.Client.GetIpoCalendar(new());
}
