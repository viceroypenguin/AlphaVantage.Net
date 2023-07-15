namespace AlphaVantage.Fundamentals;

/// <summary>
/// Annual and Quarterly Balance Sheet reports for an equity
/// </summary>
public sealed class BalanceSheetResponse
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
public sealed class BalanceSheetReport
{
#pragma warning disable CS1591
	public required DateOnly FiscalDateEnding { get; set; }
	public required string ReportedCurrency { get; set; }
	public decimal? TotalAssets { get; set; }
	public decimal? TotalCurrentAssets { get; set; }
	public decimal? CashAndCashEquivalentsAtCarryingValue { get; set; }
	public decimal? CashAndShortTermInvestments { get; set; }
	public decimal? Inventory { get; set; }
	public decimal? CurrentNetReceivables { get; set; }
	public decimal? TotalNonCurrentAssets { get; set; }
	public decimal? PropertyPlantEquipment { get; set; }
	public decimal? AccumulatedDepreciationAmortizationPPE { get; set; }
	public decimal? IntangibleAssets { get; set; }
	public decimal? IntangibleAssetsExcludingGoodwill { get; set; }
	public decimal? Goodwill { get; set; }
	public decimal? Investments { get; set; }
	public decimal? LongTermInvestments { get; set; }
	public decimal? ShortTermInvestments { get; set; }
	public decimal? OtherCurrentAssets { get; set; }
	public decimal? OtherNonCurrentAssets { get; set; }
	public decimal? TotalLiabilities { get; set; }
	public decimal? TotalCurrentLiabilities { get; set; }
	public decimal? CurrentAccountsPayable { get; set; }
	public decimal? DeferredRevenue { get; set; }
	public decimal? CurrentDebt { get; set; }
	public decimal? ShortTermDebt { get; set; }
	public decimal? TotalNonCurrentLiabilities { get; set; }
	public decimal? CapitalLeaseObligations { get; set; }
	public decimal? LongTermDebt { get; set; }
	public decimal? CurrentLongTermDebt { get; set; }
	public decimal? LongTermDebtNoncurrent { get; set; }
	public decimal? ShortLongTermDebtTotal { get; set; }
	public decimal? OtherCurrentLiabilities { get; set; }
	public decimal? OtherNonCurrentLiabilities { get; set; }
	public decimal? TotalShareholderEquity { get; set; }
	public decimal? TreasuryStock { get; set; }
	public decimal? RetainedEarnings { get; set; }
	public decimal? CommonStock { get; set; }
	public decimal? CommonStockSharesOutstanding { get; set; }
#pragma warning restore CS1591
}
