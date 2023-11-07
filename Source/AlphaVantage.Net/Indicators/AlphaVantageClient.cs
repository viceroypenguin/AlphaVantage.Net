using AlphaVantage.Indicators;

namespace AlphaVantage;

public sealed partial class AlphaVantageClient
{
	/// <summary>
	/// This API returns the annual and quarterly Real GDP of the United States.
	/// </summary>
	/// <param name="request">The parameters for the Real GDP API call</param>
	/// <param name="cancellationToken">The optional cancellation token to be used for cancelling the API call at any
	/// time.</param>
	/// <returns>The requested list of historical GDP values.</returns>
	/// <remarks>
	/// Source: U.S. Bureau of Economic Analysis, Real Gross Domestic Product, retrieved from FRED, Federal Reserve Bank
	/// of St. Louis. This data feed uses the FRED® API but is not endorsed or certified by the Federal Reserve Bank of
	/// St. Louis. By using this data feed, you agree to be bound by the <a
	/// href="https://fred.stlouisfed.org/docs/api/terms_of_use.html">FRED® API Terms of Use</a>.
	/// </remarks>
	public Task<IndicatorResponse> GetRealGdp(RealGdpRequest request, CancellationToken cancellationToken = default) =>
		WrapJsonCall(() => _alphaVantageApi.GetRealGdp(_apiKey, request, cancellationToken), cancellationToken);

	/// <summary>
	/// This API returns the quarterly Real GDP per Capita data of the United States.
	/// </summary>
	/// <param name="request">The parameters for the Real GDP per Capita API call</param>
	/// <param name="cancellationToken">The optional cancellation token to be used for cancelling the API call at any
	/// time.</param>
	/// <returns>The requested list of historical GDP values.</returns>
	/// <remarks>
	/// Source: U.S. Bureau of Economic Analysis, Real gross domestic product per capita, retrieved from FRED, Federal
	/// Reserve Bank of St. Louis. This data feed uses the FRED® API but is not endorsed or certified by the Federal
	/// Reserve Bank of St. Louis. By using this data feed, you agree to be bound by the <a
	/// href="https://fred.stlouisfed.org/docs/api/terms_of_use.html">FRED® API Terms of Use</a>.
	/// </remarks>
	public Task<IndicatorResponse> GetRealGdpPerCapita(RealGdpPerCapitaRequest request, CancellationToken cancellationToken = default) =>
		WrapJsonCall(() => _alphaVantageApi.GetRealGdpPerCapita(_apiKey, request, cancellationToken), cancellationToken);

	/// <summary>
	/// This API returns the daily, weekly, and monthly US treasury yield of a given maturity timeline (e.g., 5 year, 30
	/// year, etc).
	/// </summary>
	/// <param name="request">The parameters for the Treasury Yield API call</param>
	/// <param name="cancellationToken">The optional cancellation token to be used for cancelling the API call at any
	/// time.</param>
	/// <returns>The requested list of Treasury Yield values.</returns>
	/// <remarks>
	/// Source: Board of Governors of the Federal Reserve System (US), Market Yield on U.S. Treasury Securities at
	/// 3-month, 2-year, 5-year, 7-year, 10-year, and 30-year Constant Maturities, Quoted on an Investment Basis,
	/// retrieved from FRED, Federal Reserve Bank of St. Louis. This data feed uses the FRED® API but is not endorsed or
	/// certified by the Federal Reserve Bank of St. Louis. By using this data feed, you agree to be bound by the <a
	/// href="https://fred.stlouisfed.org/docs/api/terms_of_use.html">FRED® API Terms of Use</a>.
	/// </remarks>
	public Task<IndicatorResponse> GetTreasuryYield(TreasuryYieldRequest request, CancellationToken cancellationToken = default) =>
		WrapJsonCall(() => _alphaVantageApi.GetTreasuryYield(_apiKey, request, cancellationToken), cancellationToken);

	/// <summary>
	/// This API returns the daily, weekly, and monthly federal funds rate (interest rate) of the United States.
	/// </summary>
	/// <param name="request">The parameters for the Federal Funds Rate API call</param>
	/// <param name="cancellationToken">The optional cancellation token to be used for cancelling the API call at any
	/// time.</param>
	/// <returns>The requested list of Federal Funds Rate values.</returns>
	/// <remarks>
	/// Source: Board of Governors of the Federal Reserve System (US), Federal Funds Effective Rate, retrieved from
	/// FRED, Federal Reserve Bank of St. Louis (https://fred.stlouisfed.org/series/FEDFUNDS). This data feed uses the
	/// FRED® API but is not endorsed or certified by the Federal Reserve Bank of St. Louis. By using this data feed,
	/// you agree to be bound by the <a href="https://fred.stlouisfed.org/docs/api/terms_of_use.html">FRED® API Terms of
	/// Use</a>.
	/// </remarks>
	public Task<IndicatorResponse> GetFederalFundsRate(FederalFundsRateRequest request, CancellationToken cancellationToken = default) =>
		WrapJsonCall(() => _alphaVantageApi.GetFederalFundsRate(_apiKey, request, cancellationToken), cancellationToken);
}
