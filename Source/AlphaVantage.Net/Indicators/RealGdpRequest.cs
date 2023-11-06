using System.Runtime.Serialization;

namespace AlphaVantage.Indicators;


/// <summary>
/// Time interval between two consecutive data points in the time series.
/// </summary>
public enum GdpInterval
{
#pragma warning disable CS1591
	[EnumMember(Value = "quarterly")]
	Quarterly,
	[EnumMember(Value = "annual")]
	Annual,
#pragma warning restore CS1591
}

/// <summary>
/// The parameters for <c>?function=REAL_GDP</c> api.
/// </summary>
/// <remarks>
/// See also: <seealso href="https://www.alphavantage.co/documentation/#real-gdp"/>
/// </remarks>
public sealed class RealGdpRequest
{
	/// <summary>
	/// The interval of data for which to get GDP data.
	/// </summary>
	[AliasAs("interval")]
	public required GdpInterval Interval { get; set; }
}
