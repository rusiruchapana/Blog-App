using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

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
    
    [ForeignKey("RelatedPost")]
    public int PostId { get; set; }
    
    [JsonIgnore]
    public Post RelatedPost { get; set; }
}