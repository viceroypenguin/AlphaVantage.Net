using System.Runtime.Serialization;

namespace AlphaVantage.Stocks;

/// <summary>
/// The parameters for the time series APIs.
/// </summary>
/// <remarks>
/// See also: <seealso href="https://www.alphavantage.co/documentation/#daily"/>
/// </remarks>
public sealed class DailyTimeSeriesRequest
{
	/// <summary>
	/// The symbol for which to query time series data
	/// </summary>
	[AliasAs("symbol")]
	public required string Symbol { get; set; }

	/// <summary>
	/// By default, <c><see cref="OutputSize"/>=<see cref="TimeSeriesOutputSize.Compact"/></c>. <see
	/// cref="TimeSeriesOutputSize.Compact"/> returns only the latest 100 data points; <see
	/// cref="TimeSeriesOutputSize.Full"/> returns the full-length time series of 20+ years of historical data.
	/// </summary>
	/// <remarks>This parameter is optional.</remarks>
	[AliasAs("outputsize")]
	public TimeSeriesOutputSize? OutputSize { get; set; }
}

/// <summary>
/// The allowed values to be provided to <c>OutputSize</c>.
/// </summary>
public enum TimeSeriesOutputSize
{
	/// <summary>
	/// Get only the last 100 data points for the symbol
	/// </summary>
	[EnumMember(Value = "compact")]
	Compact,

	/// <summary>
	/// Get the full-length time series of historical data for the symbol.
	/// </summary>
	[EnumMember(Value = "full")]
	Full,
}
