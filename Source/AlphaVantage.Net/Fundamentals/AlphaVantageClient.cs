﻿using AlphaVantage.Fundamentals;

namespace AlphaVantage;

public sealed partial class AlphaVantageClient
{
	/// <summary>
	/// This API returns the company information, financial ratios, and other key metrics for the equity specified. 
	/// </summary>
	/// <param name="request">The parameters for the Company Summary API call</param>
	/// <param name="cancellationToken">The optional cancellation token to be used for cancelling the API call at any time.</param>
	/// <returns>Company information, financial ratios, and other key metrics for the equity specified.</returns>
	/// <remarks>Data is generally refreshed on the same day a company reports its latest earnings and financials.</remarks>
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
	/// <remarks>Data is generally refreshed on the same day a company reports its latest earnings and
	/// financials.</remarks>
	public Task<IncomeStatementResponse> GetIncomeStatement(IncomeStatementRequest request, CancellationToken cancellationToken = default) =>
		WrapJsonCall(() => _alphaVantageApi.GetIncomeStatement(_apiKey, request, cancellationToken), cancellationToken);

	/// <summary>
	/// This API returns the annual and quarterly balance sheets for the company of interest, with normalized fields
	/// mapped to GAAP and IFRS taxonomies of the SEC.
	/// </summary>
	/// <param name="request">The parameters for the Income Statement API call</param>
	/// <param name="cancellationToken">The optional cancellation token to be used for cancelling the API call at any
	/// time.</param>
	/// <returns>Annual and quarterly balance sheets for the equity specified.</returns>
	/// <remarks>Data is generally refreshed on the same day a company reports its latest earnings and
	/// financials.</remarks>
	public Task<BalanceSheetResponse> GetBalanceSheet(BalanceSheetRequest request, CancellationToken cancellationToken = default) =>
		WrapJsonCall(() => _alphaVantageApi.GetBalanceSheet(_apiKey, request, cancellationToken), cancellationToken);
}
