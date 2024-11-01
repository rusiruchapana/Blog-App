using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogApp.Models;

public class Post
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    [StringLength(100)]
    public string Title { get; set; }
    
    [Required]
    [StringLength(500)]
    public string Content { get; set; }
    
    
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    
    
    public ICollection<Comment> Comments { get; set; }
}