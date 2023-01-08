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
	public required DateOnly? LatestQuarter { get; set; }
	public required decimal? MarketCapitalization { get; set; }
	public required decimal? EBITDA { get; set; }
	public required decimal? PERatio { get; set; }
	public required decimal? PEGRatio { get; set; }
	public required decimal? BookValue { get; set; }
	public required decimal? DividendPerShare { get; set; }
	public required decimal? DividendYield { get; set; }
	public required decimal? EPS { get; set; }
	public required decimal? RevenuePerShareTTM { get; set; }
	public required decimal? ProfitMargin { get; set; }
	public required decimal? OperatingMarginTTM { get; set; }
	public required decimal? ReturnOnAssetsTTM { get; set; }
	public required decimal? ReturnOnEquityTTM { get; set; }
	public required decimal? RevenueTTM { get; set; }
	public required decimal? GrossProfitTTM { get; set; }
	public required decimal? DilutedEPSTTM { get; set; }
	public required decimal? QuarterlyEarningsGrowthYOY { get; set; }
	public required decimal? QuarterlyRevenueGrowthYOY { get; set; }
	public required decimal? AnalystTargetPrice { get; set; }
	public required decimal? TrailingPE { get; set; }
	public required decimal? ForwardPE { get; set; }
	public required decimal? PriceToSalesRatioTTM { get; set; }
	public required decimal? PriceToBookRatio { get; set; }
	public required decimal? EVToRevenue { get; set; }
	public required decimal? EVToEBITDA { get; set; }
	public required decimal? Beta { get; set; }
	[JsonPropertyName("52WeekHigh")]
	public required decimal? _52WeekHigh { get; set; }
	[JsonPropertyName("52WeekLow")]
	public required decimal? _52WeekLow { get; set; }
	[JsonPropertyName("50DayMovingAverage")]
	public required decimal? _50DayMovingAverage { get; set; }
	[JsonPropertyName("200DayMovingAverage")]
	public required decimal? _200DayMovingAverage { get; set; }
	public required decimal? SharesOutstanding { get; set; }
	public required DateOnly? DividendDate { get; set; }
	public required DateOnly? ExDividendDate { get; set; }
#pragma warning restore CA1707
#pragma warning restore CS1591
}
