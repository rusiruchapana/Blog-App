using BlogApp.Dto.Request;
using BlogApp.Dto.Response;

namespace BlogApp.Services.Interface;

public interface ICommentService
{
    Task<CommentResponseDto> CreateComment(CommentRequestDto commentRequestDto);
    
    Task<CommentResponseDto> GetCommentById(int id);
    Task<List<CommentResponseDto>> GetAllComments();
    Task<bool> DeleteComment(int id);
    Task<CommentResponseDto> UpdateComment(int id, CommentRequestDto commentRequestDto, int postId);
}