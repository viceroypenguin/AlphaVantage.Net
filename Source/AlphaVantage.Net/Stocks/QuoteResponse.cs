using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using CsvHelper.TypeConversion;

namespace AlphaVantage;

/// <summary>
/// Latest price information about a symbol
/// </summary>
public class QuoteResponse
{
#pragma warning disable CS1591
	[Name("symbol")]
	public required string Symbol { get; set; }
	[Name("open"), NullValues("", "null")]
	public required decimal? Open { get; set; }
	[Name("high"), NullValues("", "null")]
	public required decimal? High { get; set; }
	[Name("low"), NullValues("", "null")]
	public required decimal? Low { get; set; }
	[Name("volume"), NullValues("", "null")]
	public required long? Volume { get; set; }
	[Name("latestDay"), NullValues("", "null")]
	public required DateOnly? LatestDay { get; set; }
	[Name("previousClose"), NullValues("", "null")]
	public required decimal? PreviousClose { get; set; }
	[Name("change"), NullValues("", "null")]
	public required decimal? Change { get; set; }
	[Name("changePercent"), NullValues("", "null"), TypeConverter(typeof(PercentConverter))]
	public required decimal? ChangePercent { get; set; }

	private class PercentConverter : ITypeConverter
	{
		public object? ConvertFromString(string? text, IReaderRow row, MemberMapData memberMapData) =>
			decimal.TryParse(text?.Replace("%", "", StringComparison.Ordinal), out var d) ? d : null;

		public string? ConvertToString(object? value, IWriterRow row, MemberMapData memberMapData) =>
			throw new NotImplementedException();
	}
#pragma warning restore CS1591
}
