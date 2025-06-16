using AspApi.Dtos.Comments;
using AspApi.Models;

namespace AspApi.Mappers;

public static class CommentMapper
{
    public static CommentDtos ToCommentDto(this Comment comment)
    {
        return new CommentDtos
        {
           Title = comment.Title,
           Content = comment.Content,
           CreatedOn = comment.CreatedOn,
        };
    }
    
    public static Comment ToComment(this CreateCommentRequestDto createCommentRequest)
    {
        return new Comment
        {
            Title = createCommentRequest.Title,
            Content = createCommentRequest.Content,
            CreatedOn = createCommentRequest.CreatedOn,
        };
    }

    public static Comment ToUpdateComment(this UpdateCommentDto updateCommentDto)
    {
        return new Comment
        {
            Title = updateCommentDto.Title,
            Content = updateCommentDto.Content,
        };
    }
}