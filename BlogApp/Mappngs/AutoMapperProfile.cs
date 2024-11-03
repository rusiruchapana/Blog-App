using AutoMapper;
using BlogApp.Dto.Request;
using BlogApp.Dto.Response;
using BlogApp.Models;

namespace BlogApp.Mappngs;

public class AutoMapperProfile: Profile
{
    public AutoMapperProfile()
    {
        CreateMap<PostRequestDto , Post>();
        CreateMap<Post , PostResponseDto>();

        CreateMap<CommentRequestDto , Comment>();
        CreateMap<Comment , CommentResponseDto>();
    }
}