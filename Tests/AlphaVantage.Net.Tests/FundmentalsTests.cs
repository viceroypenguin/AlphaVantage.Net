using Xunit;

namespace AlphaVantage.Tests;

public class FundmentalsTests : IClassFixture<AlphaVantageFixture>
{
	private readonly AlphaVantageFixture _fixture;

	public FundmentalsTests(AlphaVantageFixture fixture)
	{
		_fixture = fixture;
	}

	[Fact]
	public async Task VerifyCompanySummary() =>
		// all we're looking for is successful api query
		await _fixture.Client.GetCompanySummary(
			new()
			{
				Symbol = "IBM",
			});
}
