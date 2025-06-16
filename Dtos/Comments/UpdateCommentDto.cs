using System.ComponentModel.DataAnnotations;

namespace AspApi.Dtos.Comments;

public class UpdateCommentDto
{
    [Required]
    [MaxLength(100)]
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
}