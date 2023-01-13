using CsvHelper.Configuration.Attributes;

namespace AlphaVantage.Fundamentals;

/// <summary>
/// Information about upcoming IPOs from the IPO Calendar api.
/// </summary>
public class IpoCalendarResponse
{
#pragma warning disable CS1591
	[Name("symbol")]
	public required string Symbol { get; set; }
	[Name("name")]
	public required string Name { get; set; }
	[Name("ipoDate")]
	public required DateOnly IpoDate { get; set; }
	[Name("priceRangeLow"), NullValues("")]
	public required decimal? PriceRangeLow { get; set; }
	[Name("priceRangeHigh"), NullValues("")]
	public required decimal? PriceRangeHigh { get; set; }
	[Name("currency")]
	public required string Currency { get; set; }
	[Name("exchange")]
	public required string Exchange { get; set; }
#pragma warning restore CS1591
}
