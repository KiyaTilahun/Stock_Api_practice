using AspApi.Models;

namespace AspApi.Interfaces;

public interface ICommentInterface
{
    Task<List<Comment>> GetAllCommentsAsync();
    Task<Comment> GetOneComment(int id);
    Task<Comment> UpdateCommet(int id, Comment comment);
}