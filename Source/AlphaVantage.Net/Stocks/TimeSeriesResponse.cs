using System.Globalization;
using CsvHelper.Configuration.Attributes;

namespace AlphaVantage.Stocks;

/// <summary>
/// Equity Data about a period in a time series.
/// </summary>
public sealed class TimeSeriesResponse
{
#pragma warning disable CS1591
	[Name("timestamp", "time")]
	public required DateTime Timestamp { get; set; }
	[Name("open"), NullValues("", "null"), NumberStyles(NumberStyles.Float)]
	public decimal? Open { get; set; }
	[Name("high"), NullValues("", "null"), NumberStyles(NumberStyles.Float)]
	public decimal? High { get; set; }
	[Name("low"), NullValues("", "null"), NumberStyles(NumberStyles.Float)]
	public decimal? Low { get; set; }
	[Name("close"), NullValues("", "null"), NumberStyles(NumberStyles.Float)]
	public decimal? Close { get; set; }
	[Name("volume"), NullValues("", "null")]
	public long? Volume { get; set; }
#pragma warning restore CS1591
}
