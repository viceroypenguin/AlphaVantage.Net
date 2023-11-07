using System.Runtime.Serialization;

namespace AlphaVantage.Indicators;

/// <summary>
/// Time interval between two consecutive data points in the time series.
/// </summary>
public enum CpiInterval
{
#pragma warning disable CS1591
	[EnumMember(Value = "monthly")]
	Monthly,
	[EnumMember(Value = "semiannual")]
	SemiAnnual,
#pragma warning restore CS1591
}

/// <summary>
/// The parameters for <c>?function=CPI</c> api.
/// </summary>
/// <remarks>
/// See also: <seealso href="https://www.alphavantage.co/documentation/#cpi"/>
/// </remarks>
public sealed class CpiRequest
{
	/// <summary>
	/// The interval of data for which to get CPI data.
	/// </summary>
	[AliasAs("interval")]
	public required CpiInterval Interval { get; set; }
}
