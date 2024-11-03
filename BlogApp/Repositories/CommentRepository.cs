using BlogApp.Data;
using BlogApp.Models;
using BlogApp.Repositories.Interface;

namespace BlogApp.Repositories;

public class CommentRepository: ICommentRepository
{
    //DI
    private readonly ApplicationDbContext _context;
    public CommentRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Comment> CreateComment(Comment comment)
    {
        await _context.Comments.AddAsync(comment);
        await _context.SaveChangesAsync();
            
        return comment;
    }
}