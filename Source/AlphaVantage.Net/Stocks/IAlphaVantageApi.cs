﻿using AlphaVantage.Stocks;

namespace AlphaVantage;

internal partial interface IAlphaVantageApi
{
	[Get("/query?datatype=csv")]
	Task<Stream> GetTimeSeries(string function, string apikey, TimeSeriesRequest request, CancellationToken cancellationToken);

	[Get("/query?datatype=csv")]
	Task<Stream> GetDailyTimeSeries(string function, string apikey, DailyTimeSeriesRequest request, CancellationToken cancellationToken);

	[Get("/query?function=TIME_SERIES_INTRADAY&datatype=csv")]
	Task<Stream> GetIntradayTimeSeries(string apikey, IntradayTimeSeriesRequest request, CancellationToken cancellationToken);

	[Get("/query?function=GLOBAL_QUOTE&datatype=csv")]
	Task<Stream> GetQuote(string apikey, QuoteRequest request, CancellationToken cancellationToken);

	[Get("/query?function=SYMBOL_SEARCH&datatype=csv")]
	Task<Stream> SearchSymbol(string apikey, SymbolSearchRequest request, CancellationToken cancellationToken);

	[Get("/query?function=MARKET_STATUS&datatype=csv")]
	Task<MarketStatusResponse> GetMarketStatus(string apikey, MarketStatusRequest request, CancellationToken cancellationToken);
}
