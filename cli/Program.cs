using System.Text.Json;
using NaverCafeClient;

var httpClient = new HttpClient();
var serializerOptions = new JsonSerializerOptions
{
    WriteIndented = true
};

var cafe = new NaverCafe(10050146, "joonggonara", httpClient); // 중고나라

// 카페 대문
var gateInfo = await cafe.GetCafeGateInfo();
Console.WriteLine(JsonSerializer.Serialize(gateInfo, serializerOptions));

// 멤버 정보
var memberInfo = await cafe.GetMemberInfo();
Console.WriteLine(JsonSerializer.Serialize(memberInfo, serializerOptions));

// 게시판 목록
var sideMenuList = await cafe.GetSideMenuList();
Console.WriteLine(JsonSerializer.Serialize(sideMenuList, serializerOptions));

// 전체글
var articleList = await cafe.GetArticleList(new NaverCafeArticleListQuery());
Console.WriteLine(JsonSerializer.Serialize(articleList, serializerOptions));

// 전체게시판 공지
var noticeList = await cafe.GetNoticeList();
Console.WriteLine(JsonSerializer.Serialize(noticeList, serializerOptions));

// 인기글
var popularArticleList = await cafe.GetWeeklyPopularArticleList();
Console.WriteLine(JsonSerializer.Serialize(popularArticleList, serializerOptions));

// '중고나라 무료나눔' 게시판 글
var articleListFromBoard = await cafe.GetArticleListFromBoard("96", new NaverCafeArticleListQuery());
foreach (var a in articleListFromBoard.ArticleList)
    Console.WriteLine($"{a.Type}, {a.Item.Subject}, {a.Item.GetDesktopUrl(cafe.ClubUrl)}");

// '중고나라 무료나눔' 게시판 공지
var noticeListFromBoard = await cafe.GetNoticeListFromBoard("96");
foreach (var n in noticeListFromBoard.ArticleList)
    Console.WriteLine($"{n.Type}, {n.Item.Subject}, {n.Item.GetMobileUrl()}");
