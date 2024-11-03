using AutoMapper;
using BlogApp.Dto.Request;
using BlogApp.Dto.Response;
using BlogApp.Models;
using BlogApp.Repositories;
using BlogApp.Repositories.Interface;
using BlogApp.Services.Interface;

namespace BlogApp.Services;

public class CommentService: ICommentService
{
    //DI
    private readonly ICommentRepository _commentRepository;
    private readonly IMapper _mapper;
    public CommentService(ICommentRepository commentRepository , IMapper mapper)
    {
        _commentRepository = commentRepository;
        _mapper = mapper;
    }

    public async Task<CommentResponseDto> CreateComment(CommentRequestDto commentRequestDto)
    {
        Comment comment = _mapper.Map<Comment>(commentRequestDto);
        Comment savedComment = await _commentRepository.CreateComment(comment);

        CommentResponseDto commentResponseDto = _mapper.Map<CommentResponseDto>(savedComment);
        
        return commentResponseDto;
    }

    public async Task<List<CommentResponseDto>> GetAllComments()
    {
        List<Comment> comments = await _commentRepository.GetAllComments();
        List<CommentResponseDto> commentResponseDtos = _mapper.Map<List<CommentResponseDto>>(comments);
        return commentResponseDtos;
    }
    

    public async Task<CommentResponseDto> GetCommentById(int id)
    {
        Comment comment = await _commentRepository.GetCommentById(id);
        CommentResponseDto commentResponseDto = _mapper.Map<CommentResponseDto>(comment);
        return commentResponseDto;
    }

    public async Task<bool> DeleteComment(int id)
    {
        bool check = await _commentRepository.DeleteComment(id);
        return check;
    }
   
}