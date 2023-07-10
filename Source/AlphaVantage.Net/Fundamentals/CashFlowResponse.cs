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
	public decimal? OperatingCashflow { get; set; }
	public decimal? PaymentsForOperatingActivities { get; set; }
	public decimal? ProceedsFromOperatingActivities { get; set; }
	public decimal? ChangeInOperatingLiabilities { get; set; }
	public decimal? ChangeInOperatingAssets { get; set; }
	public decimal? DepreciationDepletionAndAmortization { get; set; }
	public decimal? CapitalExpenditures { get; set; }
	public decimal? ChangeInReceivables { get; set; }
	public decimal? ChangeInInventory { get; set; }
	public decimal? ProfitLoss { get; set; }
	public decimal? CashflowFromInvestment { get; set; }
	public decimal? CashflowFromFinancing { get; set; }
	public decimal? ProceedsFromRepaymentsOfShortTermDebt { get; set; }
	public decimal? PaymentsForRepurchaseOfCommonStock { get; set; }
	public decimal? PaymentsForRepurchaseOfEquity { get; set; }
	public decimal? PaymentsForRepurchaseOfPreferredStock { get; set; }
	public decimal? DividendPayout { get; set; }
	public decimal? DividendPayoutCommonStock { get; set; }
	public decimal? DividendPayoutPreferredStock { get; set; }
	public decimal? ProceedsFromIssuanceOfCommonStock { get; set; }
	public decimal? ProceedsFromIssuanceOfLongTermDebtAndCapitalSecuritiesNet { get; set; }
	public decimal? ProceedsFromIssuanceOfPreferredStock { get; set; }
	public decimal? ProceedsFromRepurchaseOfEquity { get; set; }
	public decimal? ProceedsFromSaleOfTreasuryStock { get; set; }
	public decimal? ChangeInCashAndCashEquivalents { get; set; }
	public decimal? ChangeInExchangeRate { get; set; }
	public decimal? NetIncome { get; set; }
#pragma warning restore CS1591
}
