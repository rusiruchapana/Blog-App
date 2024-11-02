using BlogApp.Dto.Request;
using BlogApp.Dto.Response;

namespace BlogApp.Services.Interface;

public interface IPostService
{
    Task<PostResponseDto> CreatePost(PostRequestDto postRequestDto);
}