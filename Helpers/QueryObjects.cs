namespace AspApi.Helpers;

public class QueryObjects
{
    public string? CompanyName { get; set; }
    public string? Symbol { get; set; }
    public string? SortBy { get; set; }
    public bool IsDescending { get; set; }
    public int PageNumber { get; set; } = 1;
    public int PageSize { get; set; } = 10;

}