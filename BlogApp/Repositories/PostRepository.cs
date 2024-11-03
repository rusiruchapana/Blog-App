using AutoMapper;
using BlogApp.Data;
using BlogApp.Dto.Request;
using BlogApp.Dto.Response;
using BlogApp.Models;
using BlogApp.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

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

    public async Task<List<Post>> GetAllPosts()
    {
        List<Post> posts =  await _context.Posts.ToListAsync();
        return posts;
    }

    public async Task<Post> GetPostById(int id)
    {
        Post post = await _context.Posts.Include(p=> p.Comments).FirstOrDefaultAsync(p => p.Id == id);
        return post;
    }

    public async Task<Post> Update(Post post)
    {
        _context.Posts.Update(post);
        await _context.SaveChangesAsync();
        return post;
    }
}