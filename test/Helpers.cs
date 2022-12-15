using Microsoft.EntityFrameworkCore;
using projetofinal_tryitter.Models;
using projetofinal_tryitter.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace projetofinal_tryitter.test
{
    public static class Helpers
    {
        public static TryitterContext GetContextInstanceForTests(string inMemoryDbName)
        {

            var serviceProvider = new ServiceCollection()
            .AddEntityFrameworkInMemoryDatabase()
            .BuildServiceProvider();

            var contextOptions = new DbContextOptionsBuilder<TryitterContext>()
                .UseInMemoryDatabase(inMemoryDbName)
                .UseInternalServiceProvider(serviceProvider)
                .Options;
            var context = new TryitterContext(contextOptions);
            context.Posts.AddRangeAsync(
                GetPostListForTests()
            );
            context.Usuarios.AddRangeAsync(
                GetUsuarioListForTests()
            );
            context.SaveChanges();
            return context;
        }

        public static List<Usuario> GetUsuarioListForTests() =>
            new() {
                new Usuario {
                    Nome = "Gabriel",
                    Email = "gabriel@gmail.com",
                    Modulo = "Formado",
                    Status = "",
                    Senha = "ps3rules",
                },
                new Usuario {
                    Nome = "Felipe",
                    Email = "felps@gmail.com",
                    Modulo = "back-end",
                    Status = "",
                    Senha = "12345",
                },
            };

        public static List<Post> GetPostListForTests() =>
            new() {
                new Post { Texto = "Primeiro texto", ImagemId = 1, Imagens = new List<ImageUri>(), UsuarioId = 1},
                new Post { Texto = "Segundo texto", ImagemId = 2, Imagens = new List<ImageUri>(), UsuarioId = 2},
                new Post { Texto = "Terceiro texto", ImagemId = 3, Imagens = new List<ImageUri>(), UsuarioId = 3},
            };
    }
}