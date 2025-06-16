using AspApi.Data;
using AspApi.Interfaces;
using AspApi.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace AspApi.Repository;

public class CommentRepository:ICommentInterface
{
    private readonly ApplicationDBContext _context;
    public CommentRepository(ApplicationDBContext context)
    {
        _context=context;
        
    }
    
    public Task<List<Comment>> GetAllCommentsAsync()
    {
        return _context.Comments.ToListAsync();                                                                                                                                                                                                                                                                                                                                        
    }

    public async Task<Comment> GetOneComment(int id)
    {
        return await _context.Comments.FindAsync(id);
    }

    public async Task<Comment> UpdateCommet(int id, Comment comment)
    {
        var existigcomment=await _context.Comments.FindAsync(id);
        if (existigcomment == null)
        {
            return null;
        }
        existigcomment.Title = comment.Title;
        existigcomment.Content = comment.Content;
        await _context.SaveChangesAsync();
        return existigcomment;
    }

 
}