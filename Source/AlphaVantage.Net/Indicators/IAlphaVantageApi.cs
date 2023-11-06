using AlphaVantage.Indicators;

namespace AlphaVantage;

internal partial interface IAlphaVantageApi
{
	[Get("/query?function=REAL_GDP")]
	Task<RealGdpResponse> GetRealGdp(string apikey, RealGdpRequest request, CancellationToken cancellationToken);

	[Get("/query?function=REAL_GDP_PER_CAPITA")]
	Task<RealGdpResponse> GetRealGdpPerCapita(string apikey, RealGdpPerCapitaRequest request, CancellationToken cancellationToken);
}
