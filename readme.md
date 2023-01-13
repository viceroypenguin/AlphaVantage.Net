# AlphaVantage.Net
| Name            | Status | History |
| :---            | :---   | :---    |
| GitHub Actions  | ![Build](https://github.com/viceroypenguin/AlphaVantage.Net/actions/workflows/build.yml/badge.svg) | [![GitHub Actions Build History](https://buildstats.info/github/chart/viceroypenguin/AlphaVantage.Net?branch=master&includeBuildsFromPullRequest=false)](https://github.com/viceroypenguin/AlphaVantage.Net/actions) |

[![NuGet](https://img.shields.io/nuget/v/AlphaVantage.Net.svg?style=plastic)](https://www.nuget.org/packages/AlphaVantage.Net/)
[![GitHub release](https://img.shields.io/github/release/viceroypenguin/AlphaVantage.Net.svg)](https://GitHub.com/viceroypenguin/AlphaVantage.Net/releases/)
[![GitHub license](https://img.shields.io/github/license/viceroypenguin/AlphaVantage.Net.svg)](https://github.com/viceroypenguin/AlphaVantage.Net/blob/master/license.txt) 
[![GitHub issues](https://img.shields.io/github/issues/viceroypenguin/AlphaVantage.Net.svg)](https://GitHub.com/viceroypenguin/AlphaVantage.Net/issues/) 
[![GitHub issues-closed](https://img.shields.io/github/issues-closed/viceroypenguin/AlphaVantage.Net.svg)](https://GitHub.com/viceroypenguin/AlphaVantage.Net/issues?q=is%3Aissue+is%3Aclosed) 
---

## What is AlphaVantage.Net?
AlphaVantage.Net is a library for interacting with [Alpha Vantage's](https://www.alphavantage.co/) equity APIs. See
their documentation [here](https://www.alphavantage.co/documentation/). It is supported for .net 6.0+.

### Where can I get it?
AlphaVantage.Net is available at [nuget.org](https://www.nuget.org/packages/AlphaVantage.Net).

Package Manager `PM > Install-Package AlphaVantage.Net`

### How it works?
You can make all calls to Alpha Vantage's API via the `AlphaVantage.AlphaVantageClient` class.

```c#
var client = new AlphaVantageClient(
	"<key>",
	maxApiCallsPerMinute: 5);

// Retrieving the most recent daily history for IBM.
var result = await client.GetDailyTimeSeries(
	new()
	{
		Symbol = "IBM",
	});
```

### .NET Core Configuration Options

#### Easy to use:
Call `services.AddAlphaVantageClient(IConfigurationRoot)`. This will automatically bind options from the `AlphaVantage`
section of the root; configure a named `HttpClient` for AlphaVantage.Net; and configure `AlphaVantageClient` as a
transient. 

It is recommended to use AlphaVantage.Net in this way. When using this pattern, all requested instances of
`AlphaVantageClient` will respect the common rate limit specified in the options. 

If `AlphaVantageClient` is constructed directly using the constructor, the rate limiter will only be used by that
instance of the `AlphaVantageClient`; that is, multiple instances of `AlphaVantageClient` will each have their own
rate limiter. 

<!--
#### IHttpClientFactory

Going.Plaid supports the `IHttpClientFactory` for correct usage of `HttpClient`, as described
[here](https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests).
If you choose not to call `.AddPlaid()`, because you need to customize your DI structure, it is recommended that you
call `services.AddPlaidClient()` to properly configure the `IHttpClientFactory` for Going.Plaid usage.

#### `IOptions` Support

Going.Plaid supports configuration from any configuration source via the `IOptions` pattern.
You can provide any configuration section to `.AddPlaid()` and the options will be automatically bound.
Alternatively, you may call `services.Configure<PlaidOptions>();` to configure the `PlaidOption` manually.
Once done, you can then add `PlaidClient` as a singleton by calling `services.AddSingleton<PlaidClient>()`.
-->
