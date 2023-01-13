using CsvHelper.Configuration.Attributes;

namespace AlphaVantage.Stocks;

/// <summary>
/// Equity Data about a period in a time series.
/// </summary>
public class DailyAdjustedTimeSeriesResponse
{
#pragma warning disable CS1591
	[Name("timestamp")]
	public required string Timestamp { get; set; }
	[Name("open"), NullValues("", "null")]
	public required decimal? Open { get; set; }
	[Name("high"), NullValues("", "null")]
	public required decimal? High { get; set; }
	[Name("low"), NullValues("", "null")]
	public required decimal? Low { get; set; }
	[Name("close"), NullValues("", "null")]
	public required decimal? Close { get; set; }
	[Name("adjusted_close"), NullValues("", "null")]
	public required decimal? AdjustedClose { get; set; }
	[Name("volume"), NullValues("", "null")]
	public required decimal? Volume { get; set; }
	[Name("dividend_amount"), NullValues("", "null")]
	public required decimal? DividendAmount { get; set; }
	[Name("split_coefficient"), NullValues("", "null")]
	public required decimal? SplitCoefficient { get; set; }
#pragma warning restore CS1591
}
