using System.ComponentModel.DataAnnotations;
using BlogApp.Models;

namespace BlogApp.Dto.Response;

public class PostResponseDto
{
    
    public int Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public ICollection<Comment> Comments { get; set; }
}