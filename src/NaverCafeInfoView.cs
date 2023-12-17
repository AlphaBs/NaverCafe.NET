using System.Text.Json.Serialization;

namespace NaverCafeClient;

public record NaverCafeInfoView(
    [property:JsonPropertyName("cafeId")] int CafeId,
    [property:JsonPropertyName("cafeUrl")] string? CafeUrl,
    [property:JsonPropertyName("cafeName")] string? CafeName,
    [property:JsonPropertyName("openType")] string? OpenType,
    [property:JsonPropertyName("sysopId")] string? SysOpId,
    [property:JsonPropertyName("sysopNick")] string? SysOpNick,
    [property:JsonPropertyName("openDate")] string OpenDate,
    [property:JsonPropertyName("powerCafe")] bool PowerCafe,
    [property:JsonPropertyName("dormantCafe")] bool DormantCafe,
    [property:JsonPropertyName("starJoinCafe")] bool StarJoinCafe,
    [property:JsonPropertyName("educationCafe")] bool EducationCafe,
    [property:JsonPropertyName("gameCafe")] bool GameCafe,
    [property:JsonPropertyName("teenagerHarmfulCafe")] bool TeenagerHarmfulCafe,
    [property:JsonPropertyName("townCafe")] bool TownCafe,
    [property:JsonPropertyName("regionName")] string? RegionName
);