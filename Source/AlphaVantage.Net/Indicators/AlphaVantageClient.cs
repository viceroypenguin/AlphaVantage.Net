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

	/// <summary>
	/// This API returns the monthly and semiannual consumer price index (CPI) of the United States. CPI is widely
	/// regarded as the barometer of inflation levels in the broader economy.
	/// </summary>
	/// <param name="request">The parameters for the CPI API call</param>
	/// <param name="cancellationToken">The optional cancellation token to be used for cancelling the API call at any
	/// time.</param>
	/// <returns>The requested list of historical CPI values.</returns>
	/// <remarks>
	/// Source: U.S. Bureau of Labor Statistics, Consumer Price Index for All Urban Consumers: All Items in U.S. City
	/// Average, retrieved from FRED, Federal Reserve Bank of St. Louis. This data feed uses the FRED® API but is not
	/// endorsed or certified by the Federal Reserve Bank of St. Louis. By using this data feed, you agree to be bound
	/// by the <a href="https://fred.stlouisfed.org/docs/api/terms_of_use.html">FRED® API Terms of Use</a>.
	/// </remarks>
	public Task<IndicatorResponse> GetCpi(CpiRequest request, CancellationToken cancellationToken = default) =>
		WrapJsonCall(() => _alphaVantageApi.GetCpi(_apiKey, request, cancellationToken), cancellationToken);

	/// <summary>
	/// This API returns the annual inflation rates (consumer prices) of the United States.
	/// </summary>
	/// <param name="request">The parameters for the Inflation Rates API call</param>
	/// <param name="cancellationToken">The optional cancellation token to be used for cancelling the API call at any
	/// time.</param>
	/// <returns>The requested list of historical Inflation Rate values.</returns>
	/// <remarks>
	/// Source: World Bank, Inflation, consumer prices for the United States, retrieved from FRED, Federal Reserve Bank
	/// of St. Louis. This data feed uses the FRED® API but is not endorsed or certified by the Federal Reserve Bank of
	/// St. Louis. By using this data feed, you agree to be bound by the <a
	/// href="https://fred.stlouisfed.org/docs/api/terms_of_use.html">FRED® API Terms of Use</a>.
	/// </remarks>
	public Task<IndicatorResponse> GetInflation(InflationRequest request, CancellationToken cancellationToken = default) =>
		WrapJsonCall(() => _alphaVantageApi.GetInflation(_apiKey, request, cancellationToken), cancellationToken);

	/// <summary>
	/// This API returns the monthly Advance Retail Sales: Retail Trade data of the United States.
	/// </summary>
	/// <param name="request">The parameters for the Retail Sales API call</param>
	/// <param name="cancellationToken">The optional cancellation token to be used for cancelling the API call at any
	/// time.</param>
	/// <returns>The requested list of Retail Sales values.</returns>
	/// <remarks>
	/// Source: U.S. Census Bureau, Advance Retail Sales: Retail Trade, retrieved from FRED, Federal Reserve Bank of St.
	/// Louis (https://fred.stlouisfed.org/series/RSXFSN). This data feed uses the FRED® API but is not endorsed or
	/// certified by the Federal Reserve Bank of St. Louis. By using this data feed, you agree to be bound by the <a
	/// href="https://fred.stlouisfed.org/docs/api/terms_of_use.html">FRED® API Terms of Use</a>.
	/// </remarks>
	public Task<IndicatorResponse> GetRetailSales(RetailSalesRequest request, CancellationToken cancellationToken = default) =>
		WrapJsonCall(() => _alphaVantageApi.GetRetailSales(_apiKey, request, cancellationToken), cancellationToken);

	/// <summary>
	/// This API returns the monthly manufacturers' new orders of durable goods in the United States.
	/// </summary>
	/// <param name="request">The parameters for the Durable Goods API call</param>
	/// <param name="cancellationToken">The optional cancellation token to be used for cancelling the API call at any
	/// time.</param>
	/// <returns>The requested list of Durable Goods values.</returns>
	/// <remarks>
	/// Source: U.S. Census Bureau, Manufacturers' New Orders: Durable Goods, retrieved from FRED, Federal Reserve Bank
	/// of St. Louis (https://fred.stlouisfed.org/series/UMDMNO). This data feed uses the FRED® API but is not endorsed
	/// or certified by the Federal Reserve Bank of St. Louis.  By using this data feed, you agree to be bound by the <a
	/// href="https://fred.stlouisfed.org/docs/api/terms_of_use.html">FRED® API Terms of Use</a>.
	/// </remarks>
	public Task<IndicatorResponse> GetDurables(DurablesRequest request, CancellationToken cancellationToken = default) =>
		WrapJsonCall(() => _alphaVantageApi.GetDurables(_apiKey, request, cancellationToken), cancellationToken);

	/// <summary>
	/// his API returns the monthly unemployment data of the United States. The unemployment rate represents the number
	/// of unemployed as a percentage of the labor force. Labor force data are restricted to people 16 years of age and
	/// older, who currently reside in 1 of the 50 states or the District of Columbia, who do not reside in institutions
	/// (e.g., penal and mental facilities, homes for the aged), and who are not on active duty in the Armed Forces (<a
	/// href="https://fred.stlouisfed.org/series/UNRATE">source</a>).
	/// </summary>
	/// <param name="request">The parameters for the Unemployment API call</param>
	/// <param name="cancellationToken">The optional cancellation token to be used for cancelling the API call at any
	/// time.</param>
	/// <returns>The requested list of historical Unemployment values.</returns>
	/// <remarks>
	/// Source: U.S. Bureau of Labor Statistics, Unemployment Rate, retrieved from FRED, Federal Reserve Bank of St.
	/// Louis. This data feed uses the FRED® API but is not endorsed or certified by the Federal Reserve Bank of St.
	/// Louis. By using this data feed, you agree to be bound by the <a
	/// href="https://fred.stlouisfed.org/docs/api/terms_of_use.html">FRED® API Terms of Use</a>.
	/// </remarks>
	public Task<IndicatorResponse> GetUnemployment(UnemploymentRequest request, CancellationToken cancellationToken = default) =>
		WrapJsonCall(() => _alphaVantageApi.GetUnemployment(_apiKey, request, cancellationToken), cancellationToken);

	/// <summary>
	/// This API returns the monthly US All Employees: Total Nonfarm (commonly known as Total Nonfarm Payroll), a
	/// measure of the number of U.S. workers in the economy that excludes proprietors, private household employees,
	/// unpaid volunteers, farm employees, and the unincorporated self-employed.
	/// </summary>
	/// <param name="request">The parameters for the Nonfarm Payroll API call</param>
	/// <param name="cancellationToken">The optional cancellation token to be used for cancelling the API call at any
	/// time.</param>
	/// <returns>The requested list of historical Nonfarm Payroll values.</returns>
	/// <remarks>
	/// Source: U.S. Bureau of Labor Statistics, All Employees, Total Nonfarm, retrieved from FRED, Federal Reserve Bank
	/// of St. Louis. This data feed uses the FRED® API but is not endorsed or certified by the Federal Reserve Bank of
	/// St. Louis. By using this data feed, you agree to be bound by the <a
	/// href="https://fred.stlouisfed.org/docs/api/terms_of_use.html">FRED® API Terms of Use</a>.
	/// </remarks>
	public Task<IndicatorResponse> GetNonfarmPayroll(NonfarmPayrollRequest request, CancellationToken cancellationToken = default) =>
		WrapJsonCall(() => _alphaVantageApi.GetNonfarmPayroll(_apiKey, request, cancellationToken), cancellationToken);
}
