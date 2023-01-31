using CsvHelper.Configuration.Attributes;

namespace AlphaVantage.Stocks;

/// <summary>
/// Information about symbols found by the symbol search api
/// </summary>
public class SymbolSearchResponse
{
#pragma warning disable CS1591
	[Name("symbol")]
	public required string Symbol { get; set; }
	[Name("name")]
	public required string Name { get; set; }
	[Name("type")]
	public required string Type { get; set; }
	[Name("region")]
	public required string Region { get; set; }
	[Name("marketOpen")]
	public required TimeOnly MarketOpen { get; set; }
	[Name("marketClose")]
	public required TimeOnly MarketClose { get; set; }
	[Name("timezone")]
	public required string Timezone { get; set; }
	[Name("currency")]
	public required string Currency { get; set; }
	[Name("matchScore")]
	public required double MatchScore { get; set; }

#pragma warning restore CS1591
}
