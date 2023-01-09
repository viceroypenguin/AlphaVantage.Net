namespace AlphaVantage.Fundamentals;

/// <summary>
/// The parameters for <c>?function=INCOME_STATEMENT</c> api.
/// </summary>
/// <remarks>
/// See also: <seealso href="https://www.alphavantage.co/documentation/#income-statement"/>
/// </remarks>
public sealed class IncomeStatementRequest
{
	/// <summary>
	/// The symbol for which to query company income statements.
	/// </summary>
	[AliasAs("symbol")]
	public required string Symbol { get; set; }
}
