using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogApp.Dto.Request;

public class CommentRequestDto
{
    [Required]
    [StringLength(100)]
    public string Author { get; set; }
    
    [Required]
    [StringLength(500)]
    public string Content { get; set; }
    
    [ForeignKey("Post")]
    public int PostId { get; set; }
}