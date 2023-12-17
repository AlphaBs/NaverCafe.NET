using System.Text.Json.Serialization;

namespace NaverCafeClient;

public record NaverCafeSideMenuList(
    [property: JsonPropertyName("linkMenus")] NaverCafeSideMenuList[]? LinkMenus,
    [property: JsonPropertyName("menus")] NaverCafeMenu[] Menus,
    [property: JsonPropertyName("styleCode")] string? StyleCode

);

public record NaverCafeLinkMenu(
    [property: JsonPropertyName("menuName")] string? MenuName,
    [property: JsonPropertyName("menuType")] string? MenuType,
    [property: JsonPropertyName("boardType")] string? BoardType
);

public record NaverCafeMenu(
    [property: JsonPropertyName("alarm")] bool Alarm,
    [property: JsonPropertyName("commentAlarm")] bool CommentAlarm,
    [property: JsonPropertyName("subscription")] bool Subscription,
    [property: JsonPropertyName("cafeId")] int CafeId,
    [property: JsonPropertyName("menuId")] int MenuId,
    [property: JsonPropertyName("menuName")] string? MenuName,
    [property: JsonPropertyName("menuType")] string? MenuType,
    [property: JsonPropertyName("boardType")] string? BoardType,
    [property: JsonPropertyName("linkUrl")] string? LinkUrl,
    [property: JsonPropertyName("listOrder")] int ListOrder,
    [property: JsonPropertyName("fold")] bool Fold,
    [property: JsonPropertyName("indent")] bool Indent,
    [property: JsonPropertyName("lastUpdateDate")] string? LastUpdateDate,
    [property: JsonPropertyName("searchRefDate")] string? SearchRefDate,
    [property: JsonPropertyName("badMenu")] bool BadMenu,
    [property: JsonPropertyName("favorite")] bool Favorite,
    [property: JsonPropertyName("hasNewArticle")] bool HasNewArticle,
    [property: JsonPropertyName("hasRegion")] bool HasRegion)
{
    public string GetUrl(bool isMobile)
    {
        if (isMobile)
            return $"https://m.cafe.naver.com/ca-fe/web/cafes/{CafeId}/menus/{MenuId}";
        else
            return $"https://cafe.naver.com/ArticleList.nhn?search.clubid={CafeId}&search.menuid={MenuId}&search.boardtype={BoardType}";
    }
}