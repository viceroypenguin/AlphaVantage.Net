namespace AlphaVantage.Fundamentals;

/// <summary>
/// The parameters for <c>?function=BALANCE_SHEET</c> api.
/// </summary>
/// <remarks>
/// See also: <seealso href="https://www.alphavantage.co/documentation/#balance-sheet"/>
/// </remarks>
public sealed class BalanceSheetRequest
{
	/// <summary>
	/// The symbol for which to query company income statements.
	/// </summary>
	[AliasAs("symbol")]
	public required string Symbol { get; set; }
}
