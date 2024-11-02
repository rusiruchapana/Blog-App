using AutoMapper;
using BlogApp.Data;
using BlogApp.Dto.Request;
using BlogApp.Dto.Response;
using BlogApp.Models;
using BlogApp.Repositories.Interface;

namespace BlogApp.Repositories;

public class PostRepository: IPostRepository
{
    //DI
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public PostRepository(ApplicationDbContext context , IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    
    public async Task<PostResponseDto> CreatePost(Post post)
    {
        _context.Posts.Add(post);
        await _context.SaveChangesAsync();

        PostResponseDto postResponseDto = _mapper.Map<PostResponseDto>(post);
        return postResponseDto;
    }
}