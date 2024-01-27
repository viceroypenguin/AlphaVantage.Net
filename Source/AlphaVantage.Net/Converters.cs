using System.Globalization;
using System.Text.Json.Serialization;

namespace AlphaVantage;

internal sealed class InvalidDecimalConverter : JsonConverter<decimal?>
{
	public override decimal? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
		reader.TokenType == JsonTokenType.Number ? reader.GetDecimal() :
		reader.TokenType == JsonTokenType.String
			&& decimal.TryParse(reader.GetString(), out var d) ? d :
		default(decimal?);

	public override void Write(Utf8JsonWriter writer, decimal? value, JsonSerializerOptions options)
	{
		if (value == null)
			writer.WriteNullValue();
		else
			writer.WriteNumberValue(value.Value);
	}
}

internal sealed class InvalidDateOnlyConverter : JsonConverter<DateOnly?>
{
	public override DateOnly? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
		reader.TokenType == JsonTokenType.String
		&& DateOnly.TryParse(reader.GetString(), out var d)
			? d
			: default(DateOnly?);

	public override void Write(Utf8JsonWriter writer, DateOnly? value, JsonSerializerOptions options)
	{
		if (value == null)
			writer.WriteNullValue();
		else
			writer.WriteStringValue(value.Value.ToString("yyyy'-'MM'-'dd", CultureInfo.InvariantCulture));
	}
}

#pragma warning disable CA1812

/// <inheritdoc/>
internal sealed class DateTimeOffsetConverter : JsonConverter<DateTimeOffset>
{
	public override DateTimeOffset Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
		new(
			DateTime.ParseExact(reader.GetString()!, "yyyyMMddTHHmmss", null),
			TimeSpan.Zero
		);

	public override void Write(Utf8JsonWriter writer, DateTimeOffset value, JsonSerializerOptions options) =>
		writer.WriteStringValue(value);
}
