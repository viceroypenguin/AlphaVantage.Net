using System.Threading.RateLimiting;

namespace AlphaVantage;

public sealed partial class AlphaVantageClient
{
	internal sealed class RateLimiter : IAsyncDisposable
	{
		private readonly SlidingWindowRateLimiter _limiter;

		public RateLimiter(int maxCallsPerMinute)
		{
			_limiter = new SlidingWindowRateLimiter(
				new()
				{
					PermitLimit = maxCallsPerMinute,
					QueueProcessingOrder = QueueProcessingOrder.OldestFirst,
					QueueLimit = int.MaxValue,
					Window = TimeSpan.FromMinutes(1.05),
					SegmentsPerWindow = 5,
				});
		}

		public ValueTask<RateLimitLease> AcquireAsync(CancellationToken cancellationToken) =>
			_limiter.AcquireAsync(1, cancellationToken);

		public ValueTask DisposeAsync() =>
			_limiter.DisposeAsync();
	}
}
