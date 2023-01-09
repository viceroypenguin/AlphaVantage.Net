using System.Text.Json.Serialization;

namespace AlphaVantage.Fundamentals;

/// <summary>
/// Annual and quarterly earnings information for an equity.
/// </summary>
public sealed class EarningsResponse
{
#pragma warning disable CS1591
	public required string symbol { get; set; }
	public required IReadOnlyList<AnnualEarnings> AnnualEarnings { get; set; }
	public required IReadOnlyList<QuarterlyEarnings> QuarterlyEarnings { get; set; }
#pragma warning restore CS1591
}

/// <summary>
/// Annual earnings information for an equity
/// </summary>
public class AnnualEarnings
{
#pragma warning disable CS1591
	public required DateOnly FiscalDateEnding { get; set; }
	public required decimal? ReportedEPS { get; set; }
#pragma warning restore CS1591
}

/// <summary>
/// Quarterly earnings information for an equity
/// </summary>
public class QuarterlyEarnings
{
#pragma warning disable CS1591
	public required DateOnly FiscalDateEnding { get; set; }
	public required DateOnly ReportedDate { get; set; }
	public required decimal? ReportedEPS { get; set; }
	public required decimal? EstimatedEPS { get; set; }
	public required decimal? Surprise { get; set; }
	public required decimal? SurprisePercentage { get; set; }
#pragma warning restore CS1591
}
