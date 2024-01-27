using System.Text.Json.Serialization;

namespace AlphaVantage.Sentiment;

/// <summary>
/// A list of news articles and relevance and sentiment information related to the input topic(s) or ticker(s).
/// </summary>
public class SentimentResponse
{
	/// <summary>
	/// The number of articles returned.
	/// </summary>
	[JsonPropertyName("items")]
	public required int Items { get; set; }
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	[JsonPropertyName("sentiment_score_definition")]
	public required string SentimentScoreDefinition { get; set; }
	[JsonPropertyName("relevance_score_definition")]
	public required string RelevanceScoreDefinition { get; set; }
	[JsonPropertyName("feed")]
	public required IReadOnlyList<SentimentFeedItem> Feed { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}

/// <summary>
/// Information about a single news article
/// </summary>
public class SentimentFeedItem
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	[JsonPropertyName("title")]
	public required string Title { get; set; }
	[JsonPropertyName("url")]
	public required string Url { get; set; }
	[JsonPropertyName("time_published"), JsonConverter(typeof(DateTimeOffsetConverter))]
	public required DateTimeOffset TimePublished { get; set; }
	[JsonPropertyName("authors")]
	public required IReadOnlyList<string> Authors { get; set; }
	[JsonPropertyName("summary")]
	public required string Summary { get; set; }
	[JsonPropertyName("banner_image")]
	public required string BannerImage { get; set; }
	[JsonPropertyName("source")]
	public required string Source { get; set; }
	[JsonPropertyName("category_within_source")]
	public required string CategoryWithinSource { get; set; }
	[JsonPropertyName("source_domain")]
	public required string SourceDomain { get; set; }
	[JsonPropertyName("topics")]
	public required IReadOnlyList<SentimentFeedTopic> Topics { get; set; }
	[JsonPropertyName("overall_sentiment_score")]
	public required float OverallSentimentScore { get; set; }
	[JsonPropertyName("overall_sentiment_label")]
	public required string OverallSentimentLabel { get; set; }
	[JsonPropertyName("ticker_sentiment")]
	public required IReadOnlyList<SentimentFeedTickerSentiment> TickerSentiments { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}

/// <summary>
/// Information about a single topic referenced in the news article
/// </summary>
public class SentimentFeedTopic
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	[JsonPropertyName("topic")]
	public required string Topic { get; set; }
	[JsonPropertyName("relevance_score")]
	public required string RelevanceScore { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}

/// <summary>
/// Information about a single ticker referenced in the news article
/// </summary>
public class SentimentFeedTickerSentiment
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	[JsonPropertyName("ticker")]
	public required string Ticker { get; set; }
	[JsonPropertyName("relevance_score")]
	public required string RelevanceScore { get; set; }
	[JsonPropertyName("ticker_sentiment_score")]
	public required string TickerSentimentScore { get; set; }
	[JsonPropertyName("ticker_sentiment_label")]
	public required string TickerSentimentLabel { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
