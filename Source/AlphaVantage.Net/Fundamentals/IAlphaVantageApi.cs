using AlphaVantage.Fundamentals;

namespace AlphaVantage;

internal partial interface IAlphaVantageApi
{
	[Get("/query?function=OVERVIEW")]
	Task<CompanySummaryResponse> GetCompanySummary(string apikey, CompanySummaryRequest request, CancellationToken cancellationToken);
}
