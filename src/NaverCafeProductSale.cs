using System.Text.Json.Serialization;

namespace NaverCafeClient;

public record NaverCafeProductSale(
    [property: JsonPropertyName("saleStatus")] string? SaleStatus,
    [property: JsonPropertyName("cost")] string? Cost
);