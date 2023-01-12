using AlphaVantage.Stocks;

namespace AlphaVantage;

internal partial interface IAlphaVantageApi
{
	[Get("/query?datatype=csv")]
	Task<Stream> GetTimeSeries(string function, string apikey, TimeSeriesRequest request, CancellationToken cancellationToken);
}
