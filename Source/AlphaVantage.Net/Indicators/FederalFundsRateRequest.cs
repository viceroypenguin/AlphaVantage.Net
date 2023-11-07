using System.Runtime.Serialization;

namespace AlphaVantage.Indicators;

/// <summary>
/// Time interval between two consecutive data points in the time series.
/// </summary>
public enum FederalFundsRateInterval
{
#pragma warning disable CS1591
	[EnumMember(Value = "daily")]
	Daily,
	[EnumMember(Value = "weekly")]
	Weekly,
	[EnumMember(Value = "monthly")]
	Monthly,
#pragma warning restore CS1591
}

/// <summary>
/// The parameters for <c>?function=TREASURY_YIELD</c> api.
/// </summary>
/// <remarks>
/// See also: <seealso href="https://www.alphavantage.co/documentation/#interest-rate"/>
/// </remarks>
public sealed class FederalFundsRateRequest
{
	/// <summary>
	/// The interval of data for which to get Federal Funds Rate data.
	/// </summary>
	[AliasAs("interval")]
	public required FederalFundsRateInterval Interval { get; set; }
}
