using System.Text.Json.Serialization;

namespace AlphaVantage.Stocks;

/// <summary>
/// Current Status information about various Stock Markets
/// </summary>
public sealed class MarketStatusResponse
{
#pragma warning disable CS1591
	public required string Endpoint { get; set; }
	public required IReadOnlyList<MarketStatus> Markets { get; set; }
#pragma warning restore CS1591
}

/// <summary>
/// Current Status information about a stock market
/// </summary>
public sealed class MarketStatus
{
#pragma warning disable CS1591
	[JsonPropertyName("market_type")]
	public required string MarketType { get; set; }
	[JsonPropertyName("region")]
	public required string Region { get; set; }
	[JsonPropertyName("primary_exchanges")]
	public required string PrimaryExchanges { get; set; }
	[JsonPropertyName("local_open")]
	public required string LocalOpen { get; set; }
	[JsonPropertyName("local_close")]
	public required string LocalClose { get; set; }
	[JsonPropertyName("current_status")]
	public required string CurrentStatus { get; set; }
	[JsonPropertyName("notes")]
	public required string Notes { get; set; }
#pragma warning restore CS1591
}
