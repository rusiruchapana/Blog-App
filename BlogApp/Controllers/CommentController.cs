using BlogApp.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers;

[Microsoft.AspNetCore.Components.Route("api/[controller]")]
[ApiController]
public class CommentController: ControllerBase
{
    //DI
    private readonly ICommentService _commentService;
    public CommentController(ICommentService commentService)
    {
        _commentService = commentService;
    }
    
    
}