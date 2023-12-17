using System.Text.Json.Serialization;

namespace NaverCafeClient;

public record NaverCafeArticleList(
    [property: JsonPropertyName("cafeId")] int CafeId,
    [property: JsonPropertyName("cafeName")] string? CafeName,
    [property: JsonPropertyName("cafeStaff")] bool CafeStaff,
    [property: JsonPropertyName("cafeMember")] bool CafeMember,
    [property: JsonPropertyName("blockMemberList")] object[]? BlockMemberList,
    [property: JsonPropertyName("hasNext")] bool HasNext,
    [property: JsonPropertyName("articleList")] NaverCafeArticleListTypeItem[] ArticleList
);

public record NaverCafeArticleListTypeItem(
    [property: JsonPropertyName("type")] string? Type,
    [property: JsonPropertyName("item")] NaverCafeArticleListItem Item
);

public record NaverCafeArticleListItem(
    [property: JsonPropertyName("cafeId")] int CafeId,
    [property: JsonPropertyName("articleId")] int ArticleId,
    [property: JsonPropertyName("refArticleId")] int RefArticleId,
    [property: JsonPropertyName("replyListOrder")] string? ReplyListOrder,
    [property: JsonPropertyName("menuId")] int MenuId,
    [property: JsonPropertyName("menuName")] string? MenuName,
    [property: JsonPropertyName("menuType")] string? MenuType,
    [property: JsonPropertyName("restrictMenu")] bool RestrictMenu,
    [property: JsonPropertyName("boardType")] string? BoardType,
    [property: JsonPropertyName("subject")] string? Subject,
    [property: JsonPropertyName("memberKey")] string? MemberKey,
    [property: JsonPropertyName("writerNickname")] string? WriterNickname,
    [property: JsonPropertyName("memberLevel")] int MemberLevel,
    [property: JsonPropertyName("memberLevelIconId")] int MemberLevelIconId,
    [property: JsonPropertyName("profileImage")] string? ProfileImage,
    [property: JsonPropertyName("newArticle")] bool NewArticle,
    [property: JsonPropertyName("replyArticle")] bool ReplyArticle,
    [property: JsonPropertyName("blindArticle")] bool BlindArticle,
    [property: JsonPropertyName("openArticle")] bool OpenArticle,
    [property: JsonPropertyName("marketArticle")] bool MarketArticle,
    [property: JsonPropertyName("useSafetyPayment")] bool UseSafetyPayment,
    [property: JsonPropertyName("escrow")] bool Escrow,
    [property: JsonPropertyName("onSale")] bool OnSale,
    [property: JsonPropertyName("cost")] int Cost,
    [property: JsonPropertyName("formattedCost")] string? FormattedCost,
    [property: JsonPropertyName("productSale")] NaverCafeProductSale ProductSale,
    [property: JsonPropertyName("attachImage")] bool AttachImage,
    [property: JsonPropertyName("attachMusic")] bool AttachMusic,
    [property: JsonPropertyName("attachMovie")] bool AttachMovie,
    [property: JsonPropertyName("attachFile")] bool AttachFile,
    [property: JsonPropertyName("attachMap")] bool AttachMap,
    [property: JsonPropertyName("attachGps")] bool AttachGps,
    [property: JsonPropertyName("attachPoll")] bool AttachPoll,
    [property: JsonPropertyName("attachLink")] bool AttachLink,
    [property: JsonPropertyName("attachCalendar")] bool AttachCalendar,
    [property: JsonPropertyName("popular")] bool Popular,
    [property: JsonPropertyName("enableComment")] bool EnableComment,
    [property: JsonPropertyName("hasNewComment")] bool HasNewComment,
    [property: JsonPropertyName("refArticleCount")] int RefArticleCount,
    [property: JsonPropertyName("readCount")] int ReadCount,
    [property: JsonPropertyName("commentCount")] int CommentCount,
    [property: JsonPropertyName("likeItCount")] int LikeItCount,
    [property: JsonPropertyName("writeDateTimestamp")] ulong WriteDateTimestamp,
    [property: JsonPropertyName("lastCommentedTimestampd")] ulong LastCommentedTimestamp,
    [property: JsonPropertyName("delParent")] bool DelParent,
    [property: JsonPropertyName("blogScrap")] bool BlogScrap)
{
    public string GetDesktopUrl(string clubUrl)
    {
        return $"https://cafe.naver.com/{clubUrl}/{ArticleId}";
    }

    public string GetMobileUrl()
    {
        return $"https://m.cafe.naver.com/ca-fe/web/cafes/{CafeId}/articles/{ArticleId}";
    }
}