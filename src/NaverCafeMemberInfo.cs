using System.Text.Json.Serialization;

namespace NaverCafeClient;

public record NaverCafeMemberInfo(
    [property:JsonPropertyName("memberId")] string? MemberId,
    [property:JsonPropertyName("nickName")] string? Nickname,
    [property:JsonPropertyName("cafeMember")] bool CafeMember,
    [property:JsonPropertyName("cafeManager")] bool CafeManager,
    [property:JsonPropertyName("memberLevel")] int MemberLevel,
    [property:JsonPropertyName("memberLevelIconId")] int MemberLevelIconId,
    [property:JsonPropertyName("viceManager")] bool ViceMember,
    [property:JsonPropertyName("welcomeStaff")] bool WelcomeStaff,
    [property:JsonPropertyName("designStaff")] bool DesignStaff,
    [property:JsonPropertyName("cafeStaff")] bool CafeStaff,
    [property:JsonPropertyName("onlyOptionalBoardStaff")] bool OnlyOptionalBoardStaff,
    [property:JsonPropertyName("activityStopExecutable")] bool ActivityStopExecutable,
    [property:JsonPropertyName("noticeRegistrable")] bool NoticeRegistrable,
    [property:JsonPropertyName("entireBoardStaff")] bool EntireBoardStaff,
    [property:JsonPropertyName("memberStaff")] bool MemberStaff,
    [property:JsonPropertyName("appliedAlready")] bool AppliedAlready
);