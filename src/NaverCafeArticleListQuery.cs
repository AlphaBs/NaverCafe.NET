namespace NaverCafeClient;

public class NaverCafeArticleListQuery
{
    public string? QueryType { get; set; } = "lastArticle";
    public int Page { get; set; } = 1;
    public int PerPage { get; set; } = 50;

    public string BuildQueryString()
    {
        return $"search.queryType={QueryType}&search.page={Page}&search.perPage={PerPage}";
    }
}