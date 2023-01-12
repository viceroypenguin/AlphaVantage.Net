using System.Runtime.Serialization;

namespace AlphaVantage.Stocks;

/// <summary>
/// The parameters for the intraday time series API.
/// </summary>
/// <remarks>
/// See also: <seealso href="https://www.alphavantage.co/documentation/#intraday"/>
/// </remarks>
public sealed class IntradayTimeSeriesRequest
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
	/// By default, <c><see cref="OutputSize"/>=<see cref="TimeSeriesOutputSize.Compact"/></c>. <see
	/// cref="TimeSeriesOutputSize.Compact"/> returns only the latest 100 data points; <see
	/// cref="TimeSeriesOutputSize.Full"/> returns the full-length time series of 20+ years of historical data.
	/// </summary>
	/// <remarks>This parameter is optional.</remarks>
	[AliasAs("outputsize")]
	public TimeSeriesOutputSize? OutputSize { get; set; }

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
/// Time interval between two consecutive data points in the time series.
/// </summary>
public enum TimeSeriesInterval
{
#pragma warning disable CS1591
	[EnumMember(Value = "1min")]
	OneMinute,
	[EnumMember(Value = "5min")]
	FiveMinutes,
	[EnumMember(Value = "15min")]
	FifteenMinutes,
	[EnumMember(Value = "30min")]
	ThirtyMinutes,
	[EnumMember(Value = "60min")]
	SixtyMinutes,
#pragma warning restore CS1591
}
