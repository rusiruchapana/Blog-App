using BlogApp.Models;

namespace BlogApp.Repositories.Interface;

public interface ICommentRepository
{
    Task<Comment> CreateComment(Comment comment);
}