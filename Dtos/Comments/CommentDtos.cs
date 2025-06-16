namespace AspApi.Dtos.Comments;

public class CommentDtos
{
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public DateTime CreatedOn { get; set; }=DateTime.Now;

}