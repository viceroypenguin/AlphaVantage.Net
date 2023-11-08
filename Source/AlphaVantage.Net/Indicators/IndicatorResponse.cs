namespace AlphaVantage.Indicators;

/// <summary>
/// 
/// </summary>
public sealed class IndicatorResponse
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	public required string Name { get; set; }
	public required string Interval { get; set; }
	public required string Unit { get; set; }
	public required IReadOnlyList<IndicatorDataPoint> Data { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}

/// <summary>
/// GDP data about a period
/// </summary>
public sealed class IndicatorDataPoint
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	public DateOnly Date { get; set; }
	public decimal? Value { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
