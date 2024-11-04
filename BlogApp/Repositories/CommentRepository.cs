using BlogApp.Data;
using BlogApp.Dto.Request;
using BlogApp.Models;
using BlogApp.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

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

    public async Task<List<Comment>> GetAllComments()
    {
        List<Comment> comments = await _context.Comments.ToListAsync();
        return comments;
    }

    

    public async Task<Comment> GetCommentById(int id)
    {
        Comment comment = await _context.Comments.FindAsync(id);
        return comment;
    }

    public async Task<bool> DeleteComment(int id)
    {
        Comment comment = await _context.Comments.FindAsync(id);
        if (comment == null)
            return false;
        else
        {
            _context.Comments.Remove(comment);  
            await _context.SaveChangesAsync();
            return true;
        }

        
    }

    public async Task<Comment> UpdateComment(int id, CommentRequestDto commentRequestDto, int postId)
    {
        Comment comment = await _context.Comments.FindAsync(id);
        comment.Author = commentRequestDto.Author;
        comment.Content = commentRequestDto.Content;
        comment.PostId = postId;

        _context.Comments.Update(comment);
        await _context.SaveChangesAsync();
        
        return comment;
    }
}