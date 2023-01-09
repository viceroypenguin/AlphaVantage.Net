using AlphaVantage.Fundamentals;

namespace AlphaVantage;

public sealed partial class AlphaVantageClient
{
	/// <summary>
	/// This API returns the company information, financial ratios, and other key metrics for the equity specified. 
	/// </summary>
	/// <param name="request">The parameters for the Company Summary API call</param>
	/// <param name="cancellationToken">The optional cancellation token to be used for cancelling the API call at any
	/// time.</param>
	/// <returns>Company information, financial ratios, and other key metrics for the equity specified.</returns>
	/// <remarks>
	/// Data is generally refreshed on the same day a company reports its latest earnings and financials.<br/> See also:
	/// <seealso href="https://www.alphavantage.co/documentation/#company-overview"/>
	/// </remarks>
	public Task<CompanySummaryResponse> GetCompanySummary(CompanySummaryRequest request, CancellationToken cancellationToken = default) =>
		WrapJsonCall(() => _alphaVantageApi.GetCompanySummary(_apiKey, request, cancellationToken), cancellationToken);

	/// <summary>
	/// This API returns the annual and quarterly income statements for the company of interest, with normalized fields
	/// mapped to GAAP and IFRS taxonomies of the SEC.
	/// </summary>
	/// <param name="request">The parameters for the Income Statement API call</param>
	/// <param name="cancellationToken">The optional cancellation token to be used for cancelling the API call at any
	/// time.</param>
	/// <returns>Annual and quarterly income statements for the equity specified.</returns>
	/// <remarks>
	/// Data is generally refreshed on the same day a company reports its latest earnings and financials.<br/> See also:
	/// <seealso href="https://www.alphavantage.co/documentation/#income-statement"/>
	/// </remarks>
	public Task<IncomeStatementResponse> GetIncomeStatement(IncomeStatementRequest request, CancellationToken cancellationToken = default) =>
		WrapJsonCall(() => _alphaVantageApi.GetIncomeStatement(_apiKey, request, cancellationToken), cancellationToken);

	/// <summary>
	/// This API returns the annual and quarterly balance sheets for the company of interest, with normalized fields
	/// mapped to GAAP and IFRS taxonomies of the SEC.
	/// </summary>
	/// <param name="request">The parameters for the Balance Sheet API call</param>
	/// <param name="cancellationToken">The optional cancellation token to be used for cancelling the API call at any
	/// time.</param>
	/// <returns>Annual and quarterly balance sheets for the equity specified.</returns>
	/// <remarks>
	/// Data is generally refreshed on the same day a company reports its latest earnings and financials.<br/> See also:
	/// <seealso href="https://www.alphavantage.co/documentation/#balance-sheet"/>
	/// </remarks>
	public Task<BalanceSheetResponse> GetBalanceSheet(BalanceSheetRequest request, CancellationToken cancellationToken = default) =>
		WrapJsonCall(() => _alphaVantageApi.GetBalanceSheet(_apiKey, request, cancellationToken), cancellationToken);

	/// <summary>
	/// This API returns the annual and quarterly cash flow reports for the company of interest, with normalized fields
	/// mapped to GAAP and IFRS taxonomies of the SEC.
	/// </summary>
	/// <param name="request">The parameters for the Cash Flow API call</param>
	/// <param name="cancellationToken">The optional cancellation token to be used for cancelling the API call at any
	/// time.</param>
	/// <returns>Annual and quarterly cash flow reports for the equity specified.</returns>
	/// <remarks>
	/// Data is generally refreshed on the same day a company reports its latest earnings and financials.<br/> See also:
	/// <seealso href="https://www.alphavantage.co/documentation/#cash-flow"/>
	/// </remarks>
	public Task<CashFlowResponse> GetCashFlow(CashFlowRequest request, CancellationToken cancellationToken = default) =>
		WrapJsonCall(() => _alphaVantageApi.GetCashFlow(_apiKey, request, cancellationToken), cancellationToken);

	/// <summary>
	/// This API returns the annual and quarterly earnings reports for the company of interest, with normalized fields
	/// mapped to GAAP and IFRS taxonomies of the SEC.
	/// </summary>
	/// <param name="request">The parameters for the Earnings API call</param>
	/// <param name="cancellationToken">The optional cancellation token to be used for cancelling the API call at any
	/// time.</param>
	/// <returns>Annual and quarterly earnings reports for the equity specified.</returns>
	/// <remarks>
	/// Data is generally refreshed on the same day a company reports its latest earnings and financials.<br/> See also:
	/// <seealso href="https://www.alphavantage.co/documentation/#earnings"/>
	/// </remarks>
	public Task<EarningsResponse> GetEarnings(EarningsRequest request, CancellationToken cancellationToken = default) =>
		WrapJsonCall(() => _alphaVantageApi.GetEarnings(_apiKey, request, cancellationToken), cancellationToken);

	/// <summary>
	/// This API returns a list of active or delisted US stocks and ETFs, either as of the latest trading day or at a
	/// specific time in history. The endpoint is positioned to facilitate equity research on asset lifecycle and
	/// survivorship.
	/// </summary>
	/// <param name="request">The parameters for the Listing Status API call</param>
	/// <param name="cancellationToken">The optional cancellation token to be used for cancelling the API call at any
	/// time.</param>
	/// <returns>The requested list of active or delisted stocks and ETFs.</returns>
	/// <remarks>
	/// See also: <seealso href="https://www.alphavantage.co/documentation/#listing-status"/>
	/// </remarks>
	public Task<IReadOnlyList<ListingStatusResponse>> GetListingStatus(ListingStatusRequest request, CancellationToken cancellationToken = default) =>
		WrapCsvCall<ListingStatusResponse>(() => _alphaVantageApi.GetListingStatus(_apiKey, request, cancellationToken), cancellationToken);
}
