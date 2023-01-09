namespace AlphaVantage.Fundamentals;

/// <summary>
/// The parameters for <c>?function=EARNINGS</c> api.
/// </summary>
/// <remarks>
/// See also: <seealso href="https://www.alphavantage.co/documentation/#earnings"/>
/// </remarks>
public sealed class EarningsRequest
{
	/// <summary>
	/// The symbol for which to query company earnings reports.
	/// </summary>
	[AliasAs("symbol")]
	public required string Symbol { get; set; }
}
