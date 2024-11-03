using BlogApp.Repositories.Interface;
using BlogApp.Services.Interface;

namespace BlogApp.Services;

public class CommentService: ICommentService
{
    //DI
    private readonly ICommentRepository _commentRepository;
    public CommentService(ICommentRepository commentRepository)
    {
        _commentRepository = commentRepository;
    }
}