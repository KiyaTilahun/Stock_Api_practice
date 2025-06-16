using System.ComponentModel.DataAnnotations;

namespace AspApi.Dtos.Comments;

public class CreateCommentRequestDto
{
    [Required]
    [MaxLength(100)]
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public DateTime CreatedOn { get; set; }=DateTime.Now;
}