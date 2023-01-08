using Microsoft.Extensions.Configuration;

namespace AlphaVantage;

/// <summary>
/// Implements the IOptions pattern for reading an 'AlphaVantage' section from an <see cref="IConfiguration"/> object.
/// </summary>
public class AlphaVantageOptions
{
	/// <summary>
	/// A default name in the IConfiguration that contains AlphaVantageOptions settings
	/// </summary>
	/// <remarks>
	/// Section name in configuration is configurable. This default is offered for convenience only.
	/// </remarks>
	public const string SectionKey = "AlphaVantage";

	/// <summary>
	/// The API key provided by AlphaVantage.co for access to their APIs.
	/// </summary>
	/// <remarks>
	/// You can obtain an API key by visiting <see href="https://www.alphavantage.co/support/#api-key"/>.
	/// </remarks>
	public string? ApiKey { get; set; }

	/// <summary>
	/// The Rate Limit set for the provided API key.
	/// </summary>
	public int MaxApiCallsPerMinute { get; set; }
}
