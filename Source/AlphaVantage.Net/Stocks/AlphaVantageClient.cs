using AlphaVantage.Stocks;

namespace AlphaVantage;

public sealed partial class AlphaVantageClient
{
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
		WrapCsvCall<TimeSeriesResponse>(() => _alphaVantageApi.GetTimeSeries("TIME_SERIES_DAILY", _apiKey, request, cancellationToken), cancellationToken);

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
	public Task<IReadOnlyList<TimeSeriesResponse>> GetDailyAdjustedTimeSeries(DailyTimeSeriesRequest request, CancellationToken cancellationToken = default) =>
		WrapCsvCall<TimeSeriesResponse>(() => _alphaVantageApi.GetTimeSeries("TIME_SERIES_DAILY_ADJUSTED", _apiKey, request, cancellationToken), cancellationToken);

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
