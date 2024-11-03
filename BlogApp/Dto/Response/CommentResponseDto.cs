using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BlogApp.Models;

namespace BlogApp.Dto.Response;

public class CommentResponseDto
{
    public int Id { get; set; }
    public string Author { get; set; }
    public string Content { get; set; }
    public int PostId { get; set; }
    public Post Post { get; set; }
}