using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace projetofinal_tryitter.Models 
{
[Table("Posts")]
  public class Post
  {
    [Key]
    public int PostId { get; set; }
    [MaxLength(300)]
    public string? Texto { get; set; }
    public int ImagemId { get; set; }
    public List<ImageUri>? Imagens { get; set; } = new List<ImageUri>(); 

    public int UsuarioId { get; set; }
    public Usuario? Usuario { get; set; }
  }

}


