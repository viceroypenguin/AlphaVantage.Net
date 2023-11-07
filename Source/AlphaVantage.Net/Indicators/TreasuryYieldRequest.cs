using System.Runtime.Serialization;

namespace AlphaVantage.Indicators;

/// <summary>
/// Time interval between two consecutive data points in the time series.
/// </summary>
public enum TreasuryYieldInterval
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
/// Time interval between two consecutive data points in the time series.
/// </summary>
public enum TreasuryYieldMaturity
{
#pragma warning disable CS1591
	[EnumMember(Value = "3month")]
	ThreeMonth,
	[EnumMember(Value = "2year")]
	TwoYear,
	[EnumMember(Value = "5year")]
	FiveYear,
	[EnumMember(Value = "7year")]
	SevenYear,
	[EnumMember(Value = "10year")]
	TenYear,
	[EnumMember(Value = "30year")]
	ThirtyYear,
#pragma warning restore CS1591
}

/// <summary>
/// The parameters for <c>?function=TREASURY_YIELD</c> api.
/// </summary>
/// <remarks>
/// See also: <seealso href="https://www.alphavantage.co/documentation/#treasury-yield"/>
/// </remarks>
public sealed class TreasuryYieldRequest
{
	/// <summary>
	/// The interval of data for which to get GDP data.
	/// </summary>
	[AliasAs("interval")]
	public required TreasuryYieldInterval Interval { get; set; }

	/// <summary>
	/// The time to maturity of the treasury bond.
	/// </summary>
	[AliasAs("maturity")]
	public required TreasuryYieldMaturity Maturity { get; set; }
}
