using AlphaVantage.Sentiment;

namespace AlphaVantage;

internal partial interface IAlphaVantageApi
{
	[Get("/query?function=NEWS_SENTIMENT")]
	Task<SentimentResponse> GetNewsSentiment(string apikey, SentimentRequest request, CancellationToken cancellationToken);
}
