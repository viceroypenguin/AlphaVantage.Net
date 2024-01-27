using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace AlphaVantage;

/// <summary>
/// A formatter that will print dates in ISO format
/// </summary>
[ExcludeFromCodeCoverage]
public sealed class UrlParameterFormatter : DefaultUrlParameterFormatter
{
	/// <inheritdoc />
	public override string? Format(object? parameterValue, ICustomAttributeProvider attributeProvider, Type type)
	{
		if (parameterValue is DateTimeOffset dateTime)
			return FormattableString.Invariant($"{dateTime.ToUniversalTime():yyyyMMddTHHmm}");

		return base.Format(parameterValue, attributeProvider, type);
	}
}
