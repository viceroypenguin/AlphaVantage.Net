namespace AlphaVantage.Indicators;

/// <summary>
/// 
/// </summary>
public sealed class RealGdpResponse
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	public required string Name { get; set; }
	public required GdpInterval Interval { get; set; }
	public required string Unit { get; set; }
	public required IReadOnlyList<RealGdpDataPoint> Data { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}

/// <summary>
/// GDP data about a period
/// </summary>
public sealed class RealGdpDataPoint
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	public DateOnly Date { get; set; }
	public decimal Value { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
