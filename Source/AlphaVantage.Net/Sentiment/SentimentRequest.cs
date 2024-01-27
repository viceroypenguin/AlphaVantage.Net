using System.Runtime.Serialization;

namespace AlphaVantage.Sentiment;

/// <summary>
/// The parameters for the market news and sentiment API.
/// </summary>
/// <remarks>
/// See also: <seealso href="https://www.alphavantage.co/documentation/#news-sentiment"/>
/// </remarks>
public sealed class SentimentRequest
{
	/// <summary>
	/// The stock/crypto/forex symbols of your choice.
	/// </summary>
	/// <remarks>
	/// <para>
	/// For example: <c><see cref="Tickers"/>=["IBM"]</c> will filter for articles that mention the IBM ticker; <c><see
	/// cref="Tickers"/>=["COIN","CRYPTO:BTC","FOREX:USD"</c> will filter for articles that simultaneously mention
	/// Coinbase (<c>COIN</c>), Bitcoin (<c>CRYPTO:BTC</c>), and US Dollar (<c>FOREX:USD</c>) in their content.
	/// </para>
	/// <para>
	/// This parameter is optional.
	/// </para>
	/// </remarks>
	[AliasAs("tickers"), Query(CollectionFormat.Csv)]
	public IReadOnlyList<string>? Tickers { get; set; }

	/// <summary>
	/// The news topics of your choice.
	/// </summary>
	/// <remarks>
	/// <para>
	/// For example: <c><see cref="Topics"/>=["technology"]</c> will filter for articles that write about the technology
	/// sector; <c><see cref="Topics"/>=["technology","ipo"]</c> will filter for articles that simultaneously cover
	/// technology and IPO in their content. Below is the full list of supported topics:
	/// </para>
	/// <list type="bullet">
	///		<item>Blockchain: <c>blockchain</c></item>
	///		<item>Earnings: <c>earnings</c></item>
	///		<item>IPO: <c>ipo</c></item>
	///		<item>Mergers &amp; Acquisitions: <c>mergers_and_acquisitions</c></item>
	///		<item>Financial Markets: <c>financial_markets</c></item>
	///		<item>Economy - Fiscal Policy (e.g., tax reform, government spending): <c>economy_fiscal</c></item>
	///		<item>Economy - Monetary Policy (e.g., interest rates, inflation): <c>economy_monetary</c></item>
	///		<item>Economy - Macro/Overall: <c>economy_macro</c></item>
	///		<item>Energy &amp; Transportation: <c>energy_transportation</c></item>
	///		<item>Finance: <c>finance</c></item>
	///		<item>Life Sciences: <c>life_sciences</c></item>
	///		<item>Manufacturing: <c>manufacturing</c></item>
	///		<item>Real Estate &amp; Construction: <c>real_estate</c></item>
	///		<item>Retail &amp; Wholesale: <c>retail_wholesale</c></item>
	///		<item>Technology: <c>technology</c></item>
	/// </list>
	/// <para>
	/// This parameter is optional.
	/// </para>
	/// </remarks>
	[AliasAs("topics"), Query(CollectionFormat.Csv)]
	public IReadOnlyList<string>? Topics { get; set; }

	/// <summary>
	/// In conjunction with <see cref="TimeTo"/>, the time range of the news articles you are targeting.
	/// </summary>
	/// <remarks>
	/// If <see cref="TimeFrom"/> is specified but <see cref="TimeTo"/> is missing, the API will return articles
	/// published between the <see cref="TimeFrom"/> value and the current time.
	/// </remarks>
	[AliasAs("time_from")]
	public DateTimeOffset? TimeFrom { get; set; }

	/// <summary>
	/// In conjunction with <see cref="TimeFrom"/>, the time range of the news articles you are targeting.
	/// </summary>
	/// <remarks>
	/// If <see cref="TimeFrom"/> is specified but <see cref="TimeTo"/> is missing, the API will return articles
	/// published between the <see cref="TimeFrom"/> value and the current time.
	/// </remarks>
	[AliasAs("time_to")]
	public DateTimeOffset? TimeTo { get; set; }

	/// <summary>
	/// The sort order of the articles in the response.
	/// </summary>
	/// <remarks>
	/// By default, articles are sorted according to <see cref="ArticleSortOrder.Latest"/>
	/// </remarks>
	public ArticleSortOrder? SortOrder { get; set; }

	/// <summary>
	/// Maximum number of articles to return.
	/// </summary>
	/// <remarks>
	/// By default, <c>50</c> articles are returned. Maximum allowed value is <c>1000</c>.
	/// </remarks>
	public int? Limit { get; set; }
}

/// <summary>
/// The sort order of the articles in the response.
/// </summary>
public enum ArticleSortOrder
{
	/// <summary>
	/// Newest article first
	/// </summary>
	[EnumMember(Value = "LATEST")]
	Latest,

	/// <summary>
	/// Oldest article first
	/// </summary>
	[EnumMember(Value = "EARLIEST")]
	Earliest,

	/// <summary>
	/// Most relevant article first
	/// </summary>
	[EnumMember(Value = "RELEVANCE")]
	Relevance,
}
