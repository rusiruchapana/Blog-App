using BlogApp.Dto.Request;
using BlogApp.Dto.Response;
using BlogApp.Models;

namespace BlogApp.Repositories.Interface;

public interface IPostRepository
{
    Task<PostResponseDto> CreatePost(Post post);
}