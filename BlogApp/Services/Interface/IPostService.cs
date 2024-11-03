using BlogApp.Dto.Request;
using BlogApp.Dto.Response;

namespace BlogApp.Services.Interface;

public interface IPostService
{
    Task<PostResponseDto> CreatePost(PostRequestDto postRequestDto);

    Task<List<PostResponseDto>> GetAllPosts();
    Task<PostResponseDto> GetPostById(int id);
    Task<PostResponseDto> UpdatePost(int id, PostRequestDto postRequestDto);
    Task<bool> DeletePost(int id);
}