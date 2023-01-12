namespace AlphaVantage.Stocks;

/// <summary>
/// The parameters for the time series APIs.
/// </summary>
/// <remarks>
/// See also: <seealso href="https://www.alphavantage.co/documentation/#monthly"/>
/// </remarks>
public sealed class TimeSeriesRequest
{
	/// <summary>
	/// The symbol for which to query time series data
	/// </summary>
	[AliasAs("symbol")]
	public required string Symbol { get; set; }
}
