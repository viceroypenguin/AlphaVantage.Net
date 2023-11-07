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
}
