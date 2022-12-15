using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace projetofinal_tryitter.Models 
{
  [Table("Usuarios")]
  public class Usuario 
  {
    [Key]
    public int UsuarioId { get; set; }
    public string? Nome { get; set; }
    public string? Email { get; set; }
    public string? Modulo { get; set; }
    public string? Status { get; set; }
    public string? Senha { get; set; }
    public List<Post>? Posts { get; set; }
  }
}


