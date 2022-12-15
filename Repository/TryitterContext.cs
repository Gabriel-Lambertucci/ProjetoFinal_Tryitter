using Microsoft.EntityFrameworkCore;
using projetofinal_tryitter.Models;

namespace projetofinal_tryitter.Repository
{
  public class TryitterContext : DbContext, ITryitterContext
    {
      public DbSet<Usuario> Usuarios { get; set; }
      public DbSet<Post> Posts { get; set; }
    
      public TryitterContext(DbContextOptions<TryitterContext> options) : base(options) { }
      public TryitterContext() { }

      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      {
          optionsBuilder.EnableSensitiveDataLogging();
          if(!optionsBuilder.IsConfigured){
              optionsBuilder.UseSqlServer(@"
                  Server=127.0.0.1;
                  Database=tryitter_db;
                  User=sa;
                  Password=Ps3rules@;
              ");
          }
      }

      protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Post>()
            .HasOne(p => p.Usuario)
            .WithMany(u => u.Posts)
            .HasForeignKey(p => p.UsuarioId)
            .OnDelete(DeleteBehavior.Cascade);
    }
    }
}