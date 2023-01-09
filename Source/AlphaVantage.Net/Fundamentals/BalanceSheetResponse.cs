namespace AlphaVantage.Fundamentals;

/// <summary>
/// Annual and Quarterly Balance Sheet reports for an equity
/// </summary>
public class BalanceSheetResponse
{
#pragma warning disable CS1591
	public required string Symbol { get; set; }
	public required IReadOnlyList<BalanceSheetReport> AnnualReports { get; set; }
	public required IReadOnlyList<BalanceSheetReport> QuarterlyReports { get; set; }
#pragma warning restore CS1591
}

/// <summary>
/// Details from a Balance Sheet report for an equity
/// </summary>
public class BalanceSheetReport
{
#pragma warning disable CS1591
	public required DateOnly FiscalDateEnding { get; set; }
	public required string ReportedCurrency { get; set; }
	public required decimal? TotalAssets { get; set; }
	public required decimal? TotalCurrentAssets { get; set; }
	public required decimal? CashAndCashEquivalentsAtCarryingValue { get; set; }
	public required decimal? CashAndShortTermInvestments { get; set; }
	public required decimal? Inventory { get; set; }
	public required decimal? CurrentNetReceivables { get; set; }
	public required decimal? TotalNonCurrentAssets { get; set; }
	public required decimal? PropertyPlantEquipment { get; set; }
	public required decimal? AccumulatedDepreciationAmortizationPPE { get; set; }
	public required decimal? IntangibleAssets { get; set; }
	public required decimal? IntangibleAssetsExcludingGoodwill { get; set; }
	public required decimal? Goodwill { get; set; }
	public required decimal? Investments { get; set; }
	public required decimal? LongTermInvestments { get; set; }
	public required decimal? ShortTermInvestments { get; set; }
	public required decimal? OtherCurrentAssets { get; set; }
	public required decimal? OtherNonCurrentAssets { get; set; }
	public required decimal? TotalLiabilities { get; set; }
	public required decimal? TotalCurrentLiabilities { get; set; }
	public required decimal? CurrentAccountsPayable { get; set; }
	public required decimal? DeferredRevenue { get; set; }
	public required decimal? CurrentDebt { get; set; }
	public required decimal? ShortTermDebt { get; set; }
	public required decimal? TotalNonCurrentLiabilities { get; set; }
	public required decimal? CapitalLeaseObligations { get; set; }
	public required decimal? LongTermDebt { get; set; }
	public required decimal? CurrentLongTermDebt { get; set; }
	public required decimal? LongTermDebtNoncurrent { get; set; }
	public required decimal? ShortLongTermDebtTotal { get; set; }
	public required decimal? OtherCurrentLiabilities { get; set; }
	public required decimal? OtherNonCurrentLiabilities { get; set; }
	public required decimal? TotalShareholderEquity { get; set; }
	public required decimal? TreasuryStock { get; set; }
	public required decimal? RetainedEarnings { get; set; }
	public required decimal? CommonStock { get; set; }
	public required decimal? CommonStockSharesOutstanding { get; set; }
#pragma warning restore CS1591
}
