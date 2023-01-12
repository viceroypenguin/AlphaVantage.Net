﻿using Xunit;

namespace AlphaVantage.Tests;

public class StocksTests : IClassFixture<AlphaVantageFixture>
{
	private readonly AlphaVantageFixture _fixture;

	public StocksTests(AlphaVantageFixture fixture)
	{
		_fixture = fixture;
	}

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
}
