using System.Text.Json.Serialization;

namespace AlphaVantage.Fundamentals;

/// <summary>
/// Company information, financial ratios, and other key metrics for an equity.
/// </summary>
public sealed class CompanySummaryResponse
{
#pragma warning disable CS1591
#pragma warning disable CA1707
	public required string Symbol { get; set; }
	public required string AssetType { get; set; }
	public required string Name { get; set; }
	public required string Description { get; set; }
	public required string CIK { get; set; }
	public required string Exchange { get; set; }
	public required string Currency { get; set; }
	public required string Country { get; set; }
	public required string Sector { get; set; }
	public required string Industry { get; set; }
	public required string Address { get; set; }
	public required string FiscalYearEnd { get; set; }
	public DateOnly? LatestQuarter { get; set; }
	public decimal? MarketCapitalization { get; set; }
	public decimal? EBITDA { get; set; }
	public decimal? PERatio { get; set; }
	public decimal? PEGRatio { get; set; }
	public decimal? BookValue { get; set; }
	public decimal? DividendPerShare { get; set; }
	public decimal? DividendYield { get; set; }
	public decimal? EPS { get; set; }
	public decimal? RevenuePerShareTTM { get; set; }
	public decimal? ProfitMargin { get; set; }
	public decimal? OperatingMarginTTM { get; set; }
	public decimal? ReturnOnAssetsTTM { get; set; }
	public decimal? ReturnOnEquityTTM { get; set; }
	public decimal? RevenueTTM { get; set; }
	public decimal? GrossProfitTTM { get; set; }
	public decimal? DilutedEPSTTM { get; set; }
	public decimal? QuarterlyEarningsGrowthYOY { get; set; }
	public decimal? QuarterlyRevenueGrowthYOY { get; set; }
	public decimal? AnalystTargetPrice { get; set; }
	public decimal? TrailingPE { get; set; }
	public decimal? ForwardPE { get; set; }
	public decimal? PriceToSalesRatioTTM { get; set; }
	public decimal? PriceToBookRatio { get; set; }
	public decimal? EVToRevenue { get; set; }
	public decimal? EVToEBITDA { get; set; }
	public decimal? Beta { get; set; }
	[JsonPropertyName("52WeekHigh")]
	public decimal? _52WeekHigh { get; set; }
	[JsonPropertyName("52WeekLow")]
	public decimal? _52WeekLow { get; set; }
	[JsonPropertyName("50DayMovingAverage")]
	public decimal? _50DayMovingAverage { get; set; }
	[JsonPropertyName("200DayMovingAverage")]
	public decimal? _200DayMovingAverage { get; set; }
	public decimal? SharesOutstanding { get; set; }
	public DateOnly? DividendDate { get; set; }
	public DateOnly? ExDividendDate { get; set; }
#pragma warning restore CA1707
#pragma warning restore CS1591
}
