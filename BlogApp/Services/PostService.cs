using AutoMapper;
using BlogApp.Dto.Request;
using BlogApp.Dto.Response;
using BlogApp.Mappngs;
using BlogApp.Models;
using BlogApp.Repositories.Interface;
using BlogApp.Services.Interface;

namespace BlogApp.Services;

public class PostService: IPostService
{
    //DI
    private readonly IPostRepository _postRepository;
    private readonly IMapper _mapper;

    public PostService(IPostRepository postRepository , IMapper mapper)
    {
        _postRepository = postRepository;
        _mapper = mapper;
    }

    

    
    public async Task<PostResponseDto> CreatePost(PostRequestDto postRequestDto)
    {
        Post post = _mapper.Map<Post>(postRequestDto);
        PostResponseDto postResponseDto = await _postRepository.CreatePost(post);
        return postResponseDto;
    }
}