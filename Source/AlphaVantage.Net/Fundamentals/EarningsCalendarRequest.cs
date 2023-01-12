using System.Runtime.Serialization;

namespace AlphaVantage.Fundamentals;

/// <summary>
/// The parameters for <c>?function=EARNINGS_CALENDAR</c> api.
/// </summary>
/// <remarks>
/// See also: <seealso href="https://www.alphavantage.co/documentation/#earnings-calendar"/>
/// </remarks>
public sealed class EarningsCalendarRequest
{
	/// <summary>
	/// By default, no symbol will be set for this API. When no symbol is set, the API endpoint will return the full
	/// list of company earnings scheduled. If a symbol is set, the API endpoint will return the expected earnings for
	/// that specific symbol. For example, <c><see cref="Symbol"/>=IBM</c>
	/// </summary>
	public string? Symbol { get; set; }

	/// <summary>
	/// By default or using <see cref="EarningsCalendarHorizon.ThreeMonths"/>, the API will return a list of expected
	/// company earnings in the next 3 months. You may set <see cref="Horizon"/> to <see
	/// cref="EarningsCalendarHorizon.SixMonths"/> or <see cref="EarningsCalendarHorizon.TwelveMonths"/> to query the
	/// earnings scheduled for the next 6 months or 12 months, respectively.
	/// </summary>
	public EarningsCalendarHorizon? Horizon { get; set; }
}

/// <summary>
/// The allowed values to be provided to <see cref="EarningsCalendarRequest.Horizon"/>
/// </summary>
public enum EarningsCalendarHorizon
{
#pragma warning disable CS1591
	[EnumMember(Value = "3month")]
	ThreeMonths,
	[EnumMember(Value = "6month")]
	SixMonths,
	[EnumMember(Value = "12month")]
	TwelveMonths,
#pragma warning restore CS1591
}
