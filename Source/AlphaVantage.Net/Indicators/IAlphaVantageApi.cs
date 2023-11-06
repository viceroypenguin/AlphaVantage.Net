using AlphaVantage.Indicators;

namespace AlphaVantage;

internal partial interface IAlphaVantageApi
{
	[Get("/query?function=REAL_GDP")]
	Task<RealGdpResponse> GetRealGdp(string apikey, RealGdpRequest request, CancellationToken cancellationToken);
}
