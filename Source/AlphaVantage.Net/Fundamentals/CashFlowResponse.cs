namespace AlphaVantage.Fundamentals;

/// <summary>
/// Annual and Quarterly Cash Flow reports for an equity
/// </summary>
public class CashFlowResponse
{
#pragma warning disable CS1591
	public required string Symbol { get; set; }
	public required IReadOnlyList<CashFlowReport> AnnualReports { get; set; }
	public required IReadOnlyList<CashFlowReport> QuarterlyReports { get; set; }
#pragma warning restore CS1591
}

/// <summary>
/// Details from a Cash Flow report for an equity
/// </summary>
public class CashFlowReport
{
#pragma warning disable CS1591
	public required DateOnly FiscalDateEnding { get; set; }
	public required string ReportedCurrency { get; set; }
	public required decimal? OperatingCashflow { get; set; }
	public required decimal? PaymentsForOperatingActivities { get; set; }
	public required decimal? ProceedsFromOperatingActivities { get; set; }
	public required decimal? ChangeInOperatingLiabilities { get; set; }
	public required decimal? ChangeInOperatingAssets { get; set; }
	public required decimal? DepreciationDepletionAndAmortization { get; set; }
	public required decimal? CapitalExpenditures { get; set; }
	public required decimal? ChangeInReceivables { get; set; }
	public required decimal? ChangeInInventory { get; set; }
	public required decimal? ProfitLoss { get; set; }
	public required decimal? CashflowFromInvestment { get; set; }
	public required decimal? CashflowFromFinancing { get; set; }
	public required decimal? ProceedsFromRepaymentsOfShortTermDebt { get; set; }
	public required decimal? PaymentsForRepurchaseOfCommonStock { get; set; }
	public required decimal? PaymentsForRepurchaseOfEquity { get; set; }
	public required decimal? PaymentsForRepurchaseOfPreferredStock { get; set; }
	public required decimal? DividendPayout { get; set; }
	public required decimal? DividendPayoutCommonStock { get; set; }
	public required decimal? DividendPayoutPreferredStock { get; set; }
	public required decimal? ProceedsFromIssuanceOfCommonStock { get; set; }
	public required decimal? ProceedsFromIssuanceOfLongTermDebtAndCapitalSecuritiesNet { get; set; }
	public required decimal? ProceedsFromIssuanceOfPreferredStock { get; set; }
	public required decimal? ProceedsFromRepurchaseOfEquity { get; set; }
	public required decimal? ProceedsFromSaleOfTreasuryStock { get; set; }
	public required decimal? ChangeInCashAndCashEquivalents { get; set; }
	public required decimal? ChangeInExchangeRate { get; set; }
	public required decimal? NetIncome { get; set; }
#pragma warning restore CS1591
}
