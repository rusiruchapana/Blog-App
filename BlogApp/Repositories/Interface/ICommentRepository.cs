using BlogApp.Models;

namespace BlogApp.Repositories.Interface;

public interface ICommentRepository
{
    Task<Comment> CreateComment(Comment comment);
   
    Task<Comment> GetCommentById(int id);
    Task<List<Comment>> GetAllComments();
}