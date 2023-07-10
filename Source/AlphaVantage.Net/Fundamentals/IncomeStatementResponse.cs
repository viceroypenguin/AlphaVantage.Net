namespace AlphaVantage.Fundamentals;

/// <summary>
/// Annual and Quarterly Income Statement reports for an equity
/// </summary>
public class IncomeStatementResponse
{
#pragma warning disable CS1591
	public required string Symbol { get; set; }
	public required IReadOnlyList<IncomeStatementReport> AnnualReports { get; set; }
	public required IReadOnlyList<IncomeStatementReport> QuarterlyReports { get; set; }
#pragma warning restore CS1591
}

/// <summary>
/// Details from an Income Statement report for an equity
/// </summary>
public class IncomeStatementReport
{
#pragma warning disable CS1591
	public required DateOnly FiscalDateEnding { get; set; }
	public required string ReportedCurrency { get; set; }
	public decimal? GrossProfit { get; set; }
	public decimal? TotalRevenue { get; set; }
	public decimal? CostOfRevenue { get; set; }
	public decimal? CostofGoodsAndServicesSold { get; set; }
	public decimal? OperatingIncome { get; set; }
	public decimal? SellingGeneralAndAdministrative { get; set; }
	public decimal? ResearchAndDevelopment { get; set; }
	public decimal? OperatingExpenses { get; set; }
	public decimal? InvestmentIncomeNet { get; set; }
	public decimal? NetInterestIncome { get; set; }
	public decimal? InterestIncome { get; set; }
	public decimal? InterestExpense { get; set; }
	public decimal? NonInterestIncome { get; set; }
	public decimal? OtherNonOperatingIncome { get; set; }
	public decimal? Depreciation { get; set; }
	public decimal? DepreciationAndAmortization { get; set; }
	public decimal? IncomeBeforeTax { get; set; }
	public decimal? IncomeTaxExpense { get; set; }
	public decimal? InterestAndDebtExpense { get; set; }
	public decimal? NetIncomeFromContinuingOperations { get; set; }
	public decimal? ComprehensiveIncomeNetOfTax { get; set; }
	public decimal? Ebit { get; set; }
	public decimal? Ebitda { get; set; }
	public decimal? NetIncome { get; set; }
#pragma warning restore CS1591
}
