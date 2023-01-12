using System.Runtime.Serialization;

namespace AlphaVantage.Stocks;

/// <summary>
/// The parameters for the intraday time series API.
/// </summary>
/// <remarks>
/// See also: <seealso href="https://www.alphavantage.co/documentation/#intraday"/>
/// </remarks>
public sealed class ExtendedIntradayTimeSeriesRequest
{
	/// <summary>
	/// The symbol for which to query time series data
	/// </summary>
	[AliasAs("symbol")]
	public required string Symbol { get; set; }

	/// <summary>
	/// Time interval between two consecutive data points in the time series.
	/// </summary>
	[AliasAs("interval")]
	public required TimeSeriesInterval Interval { get; set; }

	/// <summary>
	/// Two years of minute-level intraday data contains over 2 million data points, which can take up to Gigabytes of
	/// memory. To ensure optimal API response speed, the trailing 2 years of intraday data is evenly divided into 24
	/// "slices". Each slice is a 30-day window, with <see cref="TimeSeriesSlice.Year1Month1"/> being the most recent
	/// and <see cref="TimeSeriesSlice.Year2Month12"/> being the farthest from today.
	/// </summary>
	[AliasAs("slice")]
	public required TimeSeriesSlice Slice { get; set; }

	/// <summary>
	/// By default, <c><see cref="Adjusted"/>=<see langword="true"/></c> and the output time series is adjusted by
	/// historical split and dividend events. Set <c><see cref="Adjusted"/>=<see langword="false"/></c> to query raw
	/// (as-traded) intraday value
	/// </summary>
	/// <remarks>This parameter is optional.</remarks>
	[AliasAs("adjusted")]
	public bool? Adjusted { get; set; }
}

/// <summary>
/// The slice of data to query for the Extended Intraday History API.
/// </summary>
public enum TimeSeriesSlice
{
#pragma warning disable CS1591
	[EnumMember(Value = "year1month1")]
	Year1Month1,
	[EnumMember(Value = "year1month2")]
	Year1Month2,
	[EnumMember(Value = "year1month3")]
	Year1Month3,
	[EnumMember(Value = "year1month4")]
	Year1Month4,
	[EnumMember(Value = "year1month5")]
	Year1Month5,
	[EnumMember(Value = "year1month6")]
	Year1Month6,
	[EnumMember(Value = "year1month7")]
	Year1Month7,
	[EnumMember(Value = "year1month8")]
	Year1Month8,
	[EnumMember(Value = "year1month9")]
	Year1Month9,
	[EnumMember(Value = "year1month10")]
	Year1Month10,
	[EnumMember(Value = "year1month11")]
	Year1Month11,
	[EnumMember(Value = "year1month12")]
	Year1Month12,
	[EnumMember(Value = "year2month1")]
	Year2Month1,
	[EnumMember(Value = "year2month2")]
	Year2Month2,
	[EnumMember(Value = "year2month3")]
	Year2Month3,
	[EnumMember(Value = "year2month4")]
	Year2Month4,
	[EnumMember(Value = "year2month5")]
	Year2Month5,
	[EnumMember(Value = "year2month6")]
	Year2Month6,
	[EnumMember(Value = "year2month7")]
	Year2Month7,
	[EnumMember(Value = "year2month8")]
	Year2Month8,
	[EnumMember(Value = "year2month9")]
	Year2Month9,
	[EnumMember(Value = "year2month10")]
	Year2Month10,
	[EnumMember(Value = "year2month11")]
	Year2Month11,
	[EnumMember(Value = "year2month12")]
	Year2Month12,
#pragma warning restore CS1591
}
