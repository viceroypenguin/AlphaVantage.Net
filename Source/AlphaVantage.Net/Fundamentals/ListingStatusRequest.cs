using System.Runtime.Serialization;

namespace AlphaVantage.Fundamentals;

/// <summary>
/// The parameters for <c>?function=LISTING_STATUS</c> api.
/// </summary>
/// <remarks>
/// See also: <seealso href="https://www.alphavantage.co/documentation/#listing-status"/>
/// </remarks>
public sealed class ListingStatusRequest
{
	/// <summary>
	/// If no date is set, the API endpoint will return a list of active or delisted symbols as of the latest trading
	/// day. If a date is set, the API endpoint will "travel back" in time and return a list of active or delisted
	/// symbols on that particular date in history. Any YYYY-MM-DD date later than 2010-01-01 is supported. For example,
	/// <c>date=2013-08-03</c>
	/// </summary>
	/// <remarks>This parameter is optional.</remarks>
	[AliasAs("date"), Query(Format = "yyyy-MM-dd")]
	public DateOnly? Date { get; set; }

	/// <summary>
	/// By default, <c>state=active</c> and the API will return a list of actively traded stocks and ETFs. Set
	/// <c>state=delisted</c> to query a list of delisted assets.
	/// </summary>
	/// <remarks>This parameter is optional.</remarks>
	[AliasAs("state")]
	public ListingStatus? State { get; set; }
}

/// <summary>
/// The allowed values to be provided to <see cref="ListingStatusRequest.State"/>
/// </summary>
public enum ListingStatus
{
	/// <summary>
	/// Query a list of actively traded stocks.
	/// </summary>
	[EnumMember(Value = "active")]
	Active,

	/// <summary>
	/// Query a list of delisted assets.
	/// </summary>
	[EnumMember(Value = "delisted")]
	Delisted,
}
