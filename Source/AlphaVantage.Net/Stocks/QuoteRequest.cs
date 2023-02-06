namespace AlphaVantage.Stocks;

/// <summary>
/// The parameters for <c>?function=GLOBAL_QUOTE</c> api.
/// </summary>
/// <remarks>
/// See also: <seealso href="https://www.alphavantage.co/documentation/#latestprice"/>
/// </remarks>
public sealed class QuoteRequest
{
	/// <summary>
	/// The symbol of the global token of your choice.
	/// </summary>
	[AliasAs("symbol")]
	public required string Symbol { get; set; }
}
