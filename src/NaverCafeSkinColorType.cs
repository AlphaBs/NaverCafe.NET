using System.Text.Json.Serialization;

namespace NaverCafeClient;

public record NaverCafeSkinColorType(
    [property:JsonPropertyName("type")] string? Type,
    [property:JsonPropertyName("cssFilePostfix")] string? CssFilePostfix
);