namespace AlphaVantage.Fundamentals;

/// <summary>
/// The parameters for <c>?function=CASH_FLOW</c> api.
/// </summary>
/// <remarks>
/// See also: <seealso href="https://www.alphavantage.co/documentation/#cash-flow"/>
/// </remarks>
public sealed class CashFlowRequest
{
	/// <summary>
	/// The symbol for which to query company cash flow reports.
	/// </summary>
	[AliasAs("symbol")]
	public required string Symbol { get; set; }
}
