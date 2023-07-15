using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using CsvHelper.TypeConversion;

namespace AlphaVantage;

/// <summary>
/// Latest price information about a symbol
/// </summary>
public sealed class QuoteResponse
{
#pragma warning disable CS1591
	[Name("symbol")]
	public required string Symbol { get; set; }
	[Name("open"), NullValues("", "null")]
	public decimal? Open { get; set; }
	[Name("high"), NullValues("", "null")]
	public decimal? High { get; set; }
	[Name("low"), NullValues("", "null")]
	public decimal? Low { get; set; }
	[Name("volume"), NullValues("", "null")]
	public long? Volume { get; set; }
	[Name("latestDay"), NullValues("", "null")]
	public DateOnly? LatestDay { get; set; }
	[Name("previousClose"), NullValues("", "null")]
	public decimal? PreviousClose { get; set; }
	[Name("change"), NullValues("", "null")]
	public decimal? Change { get; set; }
	[Name("changePercent"), NullValues("", "null"), TypeConverter(typeof(PercentConverter))]
	public decimal? ChangePercent { get; set; }

#pragma warning disable CA1812 // Avoid uninstantiated internal classes
	private sealed class PercentConverter : ITypeConverter
	{
		public object? ConvertFromString(string? text, IReaderRow row, MemberMapData memberMapData) =>
			decimal.TryParse(text?.Replace("%", "", StringComparison.Ordinal), out var d) ? d : null;

		public string? ConvertToString(object? value, IWriterRow row, MemberMapData memberMapData) =>
			throw new NotImplementedException();
	}
#pragma warning restore CA1812
#pragma warning restore CS1591
}
