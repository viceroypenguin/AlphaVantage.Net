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

	[Get("/query?function=CASH_FLOW")]
	Task<CashFlowResponse> GetCashFlow(string apikey, CashFlowRequest request, CancellationToken cancellationToken);

	[Get("/query?function=EARNINGS")]
	Task<EarningsResponse> GetEarnings(string apikey, EarningsRequest request, CancellationToken cancellationToken);

	[Get("/query?function=LISTING_STATUS")]
	Task<Stream> GetListingStatus(string apikey, ListingStatusRequest request, CancellationToken cancellationToken);

	[Get("/query?function=EARNINGS_CALENDAR")]
	Task<Stream> GetEarningsCalendar(string apikey, EarningsCalendarRequest request, CancellationToken cancellationToken);
}
