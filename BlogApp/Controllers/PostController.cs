using BlogApp.Dto.Request;
using BlogApp.Dto.Response;
using BlogApp.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PostController: ControllerBase
{
    //DI
    private readonly IPostService _postService;

    public PostController(IPostService postService)
    {
        _postService = postService;
    }
    
    
    
    //POST Rest API.
    [HttpPost]
    public async Task<IActionResult> CreatePost([FromBody] PostRequestDto postRequestDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        PostResponseDto postResponseDto = await _postService.CreatePost(postRequestDto);
        return Ok(postResponseDto);
    }

    //GET ALL Rest API.
    [HttpGet]
    public async Task<IActionResult> GetAllPosts()
    {
        List<PostResponseDto> postResponseDtos = await _postService.GetAllPosts();
        return Ok(postResponseDtos);
    }

    //GET BY ID Rest API.
    [HttpGet("id")]
    public async Task<IActionResult> GetPostById(int id)
    {
        PostResponseDto postResponseDto = await _postService.GetPostById(id);
        return Ok(postResponseDto);
    }


}