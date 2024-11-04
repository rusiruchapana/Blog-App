using BlogApp.Dto.Request;
using BlogApp.Dto.Response;
using BlogApp.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CommentController: ControllerBase
{
    //DI
    private readonly ICommentService _commentService;
    public CommentController(ICommentService commentService)
    {
        _commentService = commentService;
    }
    
    //POST Rest API.
    [HttpPost]
    public async Task<IActionResult> CreateComment(CommentRequestDto commentRequestDto)
    {
        CommentResponseDto commentResponseDto = await _commentService.CreateComment(commentRequestDto);
        return Ok(commentResponseDto);
    }

    //GET Rest API.
    [HttpGet]
    public async Task<IActionResult> GetAllComments()
    {
        List<CommentResponseDto> commentResponseDtos = await _commentService.GetAllComments();
        return Ok(commentResponseDtos);
    }

    //GET Rest API to get unique comment.
    [HttpGet("id")]
    public async Task<IActionResult> GetCommentById(int id)
    {
        CommentResponseDto commentResponseDto = await _commentService.GetCommentById(id);
        return Ok(commentResponseDto);
    }

    
    //UPDATE Rest API.
    [HttpPut]
    public async Task<IActionResult> UpdateComment(int id , CommentRequestDto commentRequestDto, int postId)
    {
        CommentResponseDto commentResponseDto = await _commentService.UpdateComment(id , commentRequestDto , postId);
        return Ok(commentResponseDto);
    }

    
    //DELETE Rest API.
    [HttpDelete]
    public async Task<IActionResult> DeleteComment(int id)
    {
        bool check = await _commentService.DeleteComment(id);
        if (check == false)
            return BadRequest("Comment not found");
        else
            return Ok("Comment deleted");
    }

}