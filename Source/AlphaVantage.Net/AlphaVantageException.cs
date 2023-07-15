namespace AlphaVantage;

/// <summary>
/// Represents errors that occur during AlphaVantage API calls
/// </summary>
#pragma warning disable CA1032 // AlphaVantageException should only be thrown by AlphaVantage.Net code
public class AlphaVantageException : Exception
{
	/// <summary>
	/// The raw JSON returned by the server.
	/// </summary>
	public string RawJson { get; }

	internal AlphaVantageException(string message, string rawJson, Exception? innerException = default)
		: base(message, innerException)
	{
		RawJson = rawJson;
	}
}
#pragma warning restore CA1032
