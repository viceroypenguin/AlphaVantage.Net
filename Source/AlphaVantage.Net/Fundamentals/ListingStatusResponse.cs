﻿using CsvHelper.Configuration.Attributes;

namespace AlphaVantage;

/// <summary>
/// Information about a security from the Listing Status api.
/// </summary>
public class ListingStatusResponse
{
#pragma warning disable CS1591
	[Name("symbol")]
	public required string Symbol { get; set; }
	[Name("name")]
	public required string Name { get; set; }
	[Name("exchange")]
	public required string Exchange { get; set; }
	[Name("assetType")]
	public required string AssetType { get; set; }
	[Name("ipoDate")]
	public required DateOnly IpoDate { get; set; }
	[Name("delistingDate"), NullValues("null")]
	public required DateOnly? DelistingDate { get; set; }
	[Name("status")]
	public required string Status { get; set; }
#pragma warning restore CS1591
}
