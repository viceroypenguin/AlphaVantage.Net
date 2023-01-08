namespace AlphaVantage.Fundamentals;

/// <summary>
/// The parameters for <c>?function=OVERVIEW</c> api.
/// </summary>
/// <remarks>
/// See also: <seealso href="https://www.alphavantage.co/documentation/#company-overview"/>
/// </remarks>
public sealed class CompanySummaryRequest
{
	/// <summary>
	/// The symbol for which to query company information.
	/// </summary>
	[AliasAs("symbol")]
	public required string Symbol { get; set; }
}
