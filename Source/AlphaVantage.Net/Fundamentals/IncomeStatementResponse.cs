namespace AlphaVantage.Fundamentals;

/// <summary>
/// Annual and Quarterly Income Statement reports for an equity
/// </summary>
public class IncomeStatementResponse
{
#pragma warning disable CS1591
	public required string Symbol { get; set; }
	public required IReadOnlyList<AnnualReport> AnnualReports { get; set; }
	public required IReadOnlyList<QuarterlyReport> QuarterlyReports { get; set; }
#pragma warning restore CS1591
}

/// <summary>
/// Details from an annual report for an equity
/// </summary>
public class AnnualReport
{
#pragma warning disable CS1591
	public required DateOnly FiscalDateEnding { get; set; }
	public required string ReportedCurrency { get; set; }
	public required decimal? GrossProfit { get; set; }
	public required decimal? TotalRevenue { get; set; }
	public required decimal? CostOfRevenue { get; set; }
	public required decimal? CostofGoodsAndServicesSold { get; set; }
	public required decimal? OperatingIncome { get; set; }
	public required decimal? SellingGeneralAndAdministrative { get; set; }
	public required decimal? ResearchAndDevelopment { get; set; }
	public required decimal? OperatingExpenses { get; set; }
	public required decimal? InvestmentIncomeNet { get; set; }
	public required decimal? NetInterestIncome { get; set; }
	public required decimal? InterestIncome { get; set; }
	public required decimal? InterestExpense { get; set; }
	public required decimal? NonInterestIncome { get; set; }
	public required decimal? OtherNonOperatingIncome { get; set; }
	public required decimal? Depreciation { get; set; }
	public required decimal? DepreciationAndAmortization { get; set; }
	public required decimal? IncomeBeforeTax { get; set; }
	public required decimal? IncomeTaxExpense { get; set; }
	public required decimal? InterestAndDebtExpense { get; set; }
	public required decimal? NetIncomeFromContinuingOperations { get; set; }
	public required decimal? ComprehensiveIncomeNetOfTax { get; set; }
	public required decimal? Ebit { get; set; }
	public required decimal? Ebitda { get; set; }
	public required decimal? NetIncome { get; set; }
#pragma warning restore CS1591
}

/// <summary>
/// Details from a quarterly report about an equity
/// </summary>
public class QuarterlyReport
{
#pragma warning disable CS1591
	public required DateOnly FiscalDateEnding { get; set; }
	public required string ReportedCurrency { get; set; }
	public required decimal? GrossProfit { get; set; }
	public required decimal? TotalRevenue { get; set; }
	public required decimal? CostOfRevenue { get; set; }
	public required decimal? CostofGoodsAndServicesSold { get; set; }
	public required decimal? OperatingIncome { get; set; }
	public required decimal? SellingGeneralAndAdministrative { get; set; }
	public required decimal? ResearchAndDevelopment { get; set; }
	public required decimal? OperatingExpenses { get; set; }
	public required decimal? InvestmentIncomeNet { get; set; }
	public required decimal? NetInterestIncome { get; set; }
	public required decimal? InterestIncome { get; set; }
	public required decimal? InterestExpense { get; set; }
	public required decimal? NonInterestIncome { get; set; }
	public required decimal? OtherNonOperatingIncome { get; set; }
	public required decimal? Depreciation { get; set; }
	public required decimal? DepreciationAndAmortization { get; set; }
	public required decimal? IncomeBeforeTax { get; set; }
	public required decimal? IncomeTaxExpense { get; set; }
	public required decimal? InterestAndDebtExpense { get; set; }
	public required decimal? NetIncomeFromContinuingOperations { get; set; }
	public required decimal? ComprehensiveIncomeNetOfTax { get; set; }
	public required decimal? Ebit { get; set; }
	public required decimal? Ebitda { get; set; }
	public required decimal? NetIncome { get; set; }
#pragma warning restore CS1591
}
