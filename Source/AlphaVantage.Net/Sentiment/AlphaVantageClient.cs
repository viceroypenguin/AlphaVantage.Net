using AlphaVantage.Sentiment;

namespace AlphaVantage;

public sealed partial class AlphaVantageClient
{
	/// <summary>
	/// This API returns live and historical market news &amp; sentiment data from a large &amp; growing selection of
	/// premier news outlets around the world, covering stocks, cryptocurrencies, forex, and a wide range of topics such
	/// as fiscal policy, mergers &amp; acquisitions, IPOs, etc. This API, combined with our core stock API, fundamental
	/// data, and technical indicator APIs, can provide you with a 360-degree view of the financial market and the
	/// broader economy.
	/// </summary>
	/// <param name="request">The parameters for the market news and sentiment call</param>
	/// <param name="cancellationToken">The optional cancellation token to be used for cancelling the API call at any
	/// time.</param>
	/// <returns>A list of articles matching the request parameters.</returns>
	public Task<SentimentResponse> GetNewsSentiment(SentimentRequest request, CancellationToken cancellationToken = default) =>
		WrapJsonCall(() => _alphaVantageApi.GetNewsSentiment(_apiKey, request, cancellationToken), cancellationToken);
}
