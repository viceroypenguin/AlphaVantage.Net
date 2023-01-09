using AlphaVantage.Fundamentals;

namespace AlphaVantage;

internal partial interface IAlphaVantageApi
{
	[Get("/query?function=OVERVIEW")]
	Task<CompanySummaryResponse> GetCompanySummary(string apikey, CompanySummaryRequest request, CancellationToken cancellationToken);

	[Get("/query?function=INCOME_STATEMENT")]
	Task<IncomeStatementResponse> GetIncomeStatement(string apikey, IncomeStatementRequest request, CancellationToken cancellationToken);

	[Get("/query?function=BALANCE_SHEET")]
	Task<BalanceSheetResponse> GetBalanceSheet(string apikey, BalanceSheetRequest request, CancellationToken cancellationToken);
}
