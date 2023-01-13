using AlphaVantage.Stocks;

namespace AlphaVantage;

public sealed partial class AlphaVantageClient
{
	/// <summary>
	/// <para>
	/// This API returns intraday time series of the equity specified, covering <u>extended trading hours</u> where
	/// applicable (e.g., 4:00am to 8:00pm Eastern Time for the US market). The intraday data is derived from the
	/// Securities Information Processor (SIP) market-aggregated data. You can query both raw (as-traded) and
	/// split/dividend-adjusted intraday data from this endpoint.
	/// </para>
	/// <para>
	/// This API returns the most recent 1-2 months of intraday data and is best suited for short-term/medium-term
	/// charting and trading strategy development. If you are targeting a deeper intraday history, please use the
	/// Extended Intraday API.
	/// </para>
	/// </summary>
	/// <param name="request">The parameters for the Time Series API call</param>
	/// <param name="cancellationToken">The optional cancellation token to be used for cancelling the API call at any
	/// time.</param>
	/// <returns>The Intraday equity time series data.</returns>
	/// <remarks>
	/// See also: <seealso href="https://www.alphavantage.co/documentation/#intraday"/>
	/// </remarks>
	public Task<IReadOnlyList<TimeSeriesResponse>> GetIntradayTimeSeries(IntradayTimeSeriesRequest request, CancellationToken cancellationToken = default) =>
		WrapCsvCall<TimeSeriesResponse>(() => _alphaVantageApi.GetIntradayTimeSeries(_apiKey, request, cancellationToken), cancellationToken);

	/// <summary>
	/// This API returns historical intraday time series for the trailing 2 years, covering over 2 million data points
	/// per ticker. The intraday data is derived from the Securities Information Processor (SIP) market-aggregated data.
	/// You can query both raw (as-traded) and split/dividend-adjusted intraday data from this endpoint. Common use
	/// cases for this API include data visualization, trading simulation/backtesting, and machine learning and deep
	/// learning applications with a longer horizon.
	/// </summary>
	/// <param name="request">The parameters for the Time Series API call</param>
	/// <param name="cancellationToken">The optional cancellation token to be used for cancelling the API call at any
	/// time.</param>
	/// <returns>The Intraday equity time series data.</returns>
	/// <remarks>
	/// See also: <seealso href="https://www.alphavantage.co/documentation/#intraday-extended"/>
	/// </remarks>
	public Task<IReadOnlyList<TimeSeriesResponse>> GetExtendedIntradayTimeSeries(ExtendedIntradayTimeSeriesRequest request, CancellationToken cancellationToken = default) =>
		WrapCsvCall<TimeSeriesResponse>(() => _alphaVantageApi.GetExtendedIntradayTimeSeries(_apiKey, request, cancellationToken), cancellationToken);

	/// <summary>
	/// This API returns <u>raw</u> (as-traded) daily time series (date, daily open, daily high, daily low, daily close,
	/// daily volume) of the global equity specified, covering 20+ years of historical data. If you are also interested
	/// in split/dividend-adjusted historical data, please use the <see
	/// cref="GetDailyAdjustedTimeSeries(DailyTimeSeriesRequest, CancellationToken)"/> API, which covers adjusted close
	/// values and historical split and dividend events.
	/// </summary>
	/// <param name="request">The parameters for the Time Series API call</param>
	/// <param name="cancellationToken">The optional cancellation token to be used for cancelling the API call at any
	/// time.</param>
	/// <returns>The Daily equity time series data.</returns>
	/// <remarks>
	/// See also: <seealso href="https://www.alphavantage.co/documentation/#daily"/>
	/// </remarks>
	public Task<IReadOnlyList<TimeSeriesResponse>> GetDailyTimeSeries(DailyTimeSeriesRequest request, CancellationToken cancellationToken = default) =>
		WrapCsvCall<TimeSeriesResponse>(() => _alphaVantageApi.GetDailyTimeSeries("TIME_SERIES_DAILY", _apiKey, request, cancellationToken), cancellationToken);

	/// <summary>
	/// This API returns raw (as-traded) daily open/high/low/close/volume values, daily adjusted close values, and
	/// historical split/dividend events of the global equity specified, covering 20+ years of historical data.
	/// </summary>
	/// <param name="request">The parameters for the Time Series API call</param>
	/// <param name="cancellationToken">The optional cancellation token to be used for cancelling the API call at any
	/// time.</param>
	/// <returns>The Daily adjusted equity time series data.</returns>
	/// <remarks>
	/// See also: <seealso href="https://www.alphavantage.co/documentation/#dailyadj"/>
	/// </remarks>
	public Task<IReadOnlyList<DailyAdjustedTimeSeriesResponse>> GetDailyAdjustedTimeSeries(DailyTimeSeriesRequest request, CancellationToken cancellationToken = default) =>
		WrapCsvCall<DailyAdjustedTimeSeriesResponse>(() => _alphaVantageApi.GetDailyTimeSeries("TIME_SERIES_DAILY_ADJUSTED", _apiKey, request, cancellationToken), cancellationToken);

	/// <summary>
	/// This API returns Weekly time series (last trading day of each month, Weekly open, Weekly high, Weekly low,
	/// Weekly close, Weekly volume) of the global equity specified, covering 20+ years of historical data.
	/// </summary>
	/// <param name="request">The parameters for the Time Series API call</param>
	/// <param name="cancellationToken">The optional cancellation token to be used for cancelling the API call at any
	/// time.</param>
	/// <returns>The Weekly equity time series data.</returns>
	/// <remarks>
	/// See also: <seealso href="https://www.alphavantage.co/documentation/#weekly"/>
	/// </remarks>
	public Task<IReadOnlyList<TimeSeriesResponse>> GetWeeklyTimeSeries(TimeSeriesRequest request, CancellationToken cancellationToken = default) =>
		WrapCsvCall<TimeSeriesResponse>(() => _alphaVantageApi.GetTimeSeries("TIME_SERIES_WEEKLY", _apiKey, request, cancellationToken), cancellationToken);

	/// <summary>
	/// This API returns Weekly adjusted time series (last trading day of each month, Weekly open, Weekly high,
	/// Weekly low, Weekly close, Weekly volume) of the global equity specified, covering 20+ years of historical
	/// data.
	/// </summary>
	/// <param name="request">The parameters for the Time Series API call</param>
	/// <param name="cancellationToken">The optional cancellation token to be used for cancelling the API call at any
	/// time.</param>
	/// <returns>The Weekly adjusted equity time series data.</returns>
	/// <remarks>
	/// See also: <seealso href="https://www.alphavantage.co/documentation/#weeklyadj"/>
	/// </remarks>
	public Task<IReadOnlyList<TimeSeriesResponse>> GetWeeklyAdjustedTimeSeries(TimeSeriesRequest request, CancellationToken cancellationToken = default) =>
		WrapCsvCall<TimeSeriesResponse>(() => _alphaVantageApi.GetTimeSeries("TIME_SERIES_WEEKLY_ADJUSTED", _apiKey, request, cancellationToken), cancellationToken);

	/// <summary>
	/// This API returns monthly time series (last trading day of each month, monthly open, monthly high, monthly low,
	/// monthly close, monthly volume) of the global equity specified, covering 20+ years of historical data.
	/// </summary>
	/// <param name="request">The parameters for the Time Series API call</param>
	/// <param name="cancellationToken">The optional cancellation token to be used for cancelling the API call at any
	/// time.</param>
	/// <returns>The monthly equity time series data.</returns>
	/// <remarks>
	/// See also: <seealso href="https://www.alphavantage.co/documentation/#monthly"/>
	/// </remarks>
	public Task<IReadOnlyList<TimeSeriesResponse>> GetMonthlyTimeSeries(TimeSeriesRequest request, CancellationToken cancellationToken = default) =>
		WrapCsvCall<TimeSeriesResponse>(() => _alphaVantageApi.GetTimeSeries("TIME_SERIES_MONTHLY", _apiKey, request, cancellationToken), cancellationToken);

	/// <summary>
	/// This API returns monthly adjusted time series (last trading day of each month, monthly open, monthly high,
	/// monthly low, monthly close, monthly volume) of the global equity specified, covering 20+ years of historical
	/// data.
	/// </summary>
	/// <param name="request">The parameters for the Time Series API call</param>
	/// <param name="cancellationToken">The optional cancellation token to be used for cancelling the API call at any
	/// time.</param>
	/// <returns>The monthly adjusted equity time series data.</returns>
	/// <remarks>
	/// See also: <seealso href="https://www.alphavantage.co/documentation/#monthlyadj"/>
	/// </remarks>
	public Task<IReadOnlyList<TimeSeriesResponse>> GetMonthlyAdjustedTimeSeries(TimeSeriesRequest request, CancellationToken cancellationToken = default) =>
		WrapCsvCall<TimeSeriesResponse>(() => _alphaVantageApi.GetTimeSeries("TIME_SERIES_MONTHLY_ADJUSTED", _apiKey, request, cancellationToken), cancellationToken);

}
