using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace projetofinal_tryitter.Models{
  public class ImageUri
  {
      [Key]
      public int ImagemId { get; set; }
      public string Uri { get; set; } = null!;
  }
  
}