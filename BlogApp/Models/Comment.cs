using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogApp.Models;

public class Comment
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [Required]
    [StringLength(100)]
    public string Author { get; set; }
    
    [Required]
    [StringLength(500)]
    public string Content { get; set; }
    
    [ForeignKey("Post")]
    public int PostId { get; set; }
    
    
    public Post Post { get; set; }
}