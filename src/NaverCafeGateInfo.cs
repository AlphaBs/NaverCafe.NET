using System.Text.Json.Serialization;

namespace NaverCafeClient;

public record NaverCafeGateInfo(
    [property:JsonPropertyName("profileImageUrl")] string? ProfileImageUrl,
    [property:JsonPropertyName("mobileGateImageUrl")] string? MobileGateImageUrl,
    [property:JsonPropertyName("mobileCafeName")] string? MobileCafeName,
    [property:JsonPropertyName("cafeInfoView")] NaverCafeInfoView? CafeInfoView,
    [property:JsonPropertyName("memberCount")] int MemberCount,
    [property:JsonPropertyName("useMemberLevel")] bool UseMemberLevel,
    [property:JsonPropertyName("readOnly")] bool ReadOnly,
    [property:JsonPropertyName("popularMenu")] bool PopularMenu,
    [property:JsonPropertyName("showPopularMember")] bool ShowPopularMember,
    [property:JsonPropertyName("popularItemStatusCode")] string? PopularItemStatusCode,
    [property:JsonPropertyName("popularArticleStatDate")] string? PopularArticleStatDate,
    [property:JsonPropertyName("styleCode")] string? StyleCode,
    [property:JsonPropertyName("skinColorType")] NaverCafeSkinColorType? SkinColorType,
    [property:JsonPropertyName("openMemberInfo")] bool OpenMemberInfo
);