using AlphaVantage.Indicators;

namespace AlphaVantage;

internal partial interface IAlphaVantageApi
{
	[Get("/query?function=REAL_GDP")]
	Task<IndicatorResponse> GetRealGdp(string apikey, RealGdpRequest request, CancellationToken cancellationToken);

	[Get("/query?function=REAL_GDP_PER_CAPITA")]
	Task<IndicatorResponse> GetRealGdpPerCapita(string apikey, RealGdpPerCapitaRequest request, CancellationToken cancellationToken);

	[Get("/query?function=TREASURY_YIELD")]
	Task<IndicatorResponse> GetTreasuryYield(string apikey, TreasuryYieldRequest request, CancellationToken cancellationToken);

	[Get("/query?function=FEDERAL_FUNDS_RATE")]
	Task<IndicatorResponse> GetFederalFundsRate(string apikey, FederalFundsRateRequest request, CancellationToken cancellationToken);

	[Get("/query?function=CPI")]
	Task<IndicatorResponse> GetCpi(string apikey, CpiRequest request, CancellationToken cancellationToken);

	[Get("/query?function=INFLATION")]
	Task<IndicatorResponse> GetInflation(string apikey, InflationRequest request, CancellationToken cancellationToken);

	[Get("/query?function=RETAIL_SALES")]
	Task<IndicatorResponse> GetRetailSales(string apikey, RetailSalesRequest request, CancellationToken cancellationToken);

	[Get("/query?function=DURABLES")]
	Task<IndicatorResponse> GetDurables(string apikey, DurablesRequest request, CancellationToken cancellationToken);

	[Get("/query?function=UNEMPLOYMENT")]
	Task<IndicatorResponse> GetUnemployment(string apikey, UnemploymentRequest request, CancellationToken cancellationToken);

	[Get("/query?function=NONFARM_PAYROLL")]
	Task<IndicatorResponse> GetNonfarmPayroll(string apikey, NonfarmPayrollRequest request, CancellationToken cancellationToken);
}
