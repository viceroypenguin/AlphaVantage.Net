using CsvHelper.Configuration.Attributes;

namespace AlphaVantage.Fundamentals;

/// <summary>
/// Information about upcoming earnings from the Earnings Calendar api.
/// </summary>
public class EarningsCalendarResponse
{
#pragma warning disable CS1591
	[Name("symbol")]
	public required string Symbol { get; set; }
	[Name("name")]
	public required string Name { get; set; }
	[Name("reportDate")]
	public required DateOnly ReportDate { get; set; }
	[Name("fiscalDateEnding")]
	public required DateOnly FiscalDateEnding { get; set; }
	[Name("estimate"), NullValues("")]
	public required decimal? Estimate { get; set; }
	[Name("currency")]
	public required string Currency { get; set; }
#pragma warning restore CS1591
}
