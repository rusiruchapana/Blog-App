using BlogApp.Data;
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
}