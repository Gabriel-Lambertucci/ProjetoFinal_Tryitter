using Microsoft.EntityFrameworkCore;
using projetofinal_tryitter.Models;

namespace projetofinal_tryitter.Repository
{
    public interface ITryitterContext
    {
        public DbSet<Usuario> Usuarios{ get; set; }
        public DbSet<Post> Posts { get; set; }
        public int SaveChanges();
    }

}