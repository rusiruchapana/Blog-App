using BlogApp.Dto.Request;
using BlogApp.Dto.Response;

namespace BlogApp.Services.Interface;

public interface ICommentService
{
    Task<CommentResponseDto> CreateComment(CommentRequestDto commentRequestDto);
}