namespace AlphaVantage.Stocks;

/// <summary>
/// The parameters for <c>?function=SYMBOL_SEARCH</c> api.
/// </summary>
/// <remarks>
/// See also: <seealso href="https://www.alphavantage.co/documentation/#symbolsearch"/>
/// </remarks>
public sealed class SymbolSearchRequest
{
	/// <summary>
	/// A text string of your choice to use as a search criteria for symbols.
	/// </summary>
	[AliasAs("keywords")]
	public required string Keyword { get; set; }
}
