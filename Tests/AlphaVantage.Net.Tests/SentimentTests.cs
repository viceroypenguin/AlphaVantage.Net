using Xunit;

namespace AlphaVantage.Tests;

public sealed class SentimentTests(AlphaVantageFixture fixture) : IClassFixture<AlphaVantageFixture>
{
	private readonly AlphaVantageFixture _fixture = fixture;

	[Fact]
	public async Task VerifySentimentByTicker() =>
		// all we're looking for is successful api query
		await _fixture.Client.GetNewsSentiment(
			new()
			{
				Tickers = ["MSFT"],
				TimeFrom = DateTimeOffset.Now.AddDays(-1),
			});

	[Fact]
	public async Task VerifySentimentByTopic() =>
		// all we're looking for is successful api query
		await _fixture.Client.GetNewsSentiment(
			new()
			{
				Topics = ["ipo"],
				TimeFrom = DateTimeOffset.Now.AddMonths(-1),
			});
}
