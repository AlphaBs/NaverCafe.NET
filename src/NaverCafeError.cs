using System.Text.Json.Serialization;

namespace NaverCafeClient;

public class NaverCafeError
{
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("msg")]
    public string? Message { get; set; }
}