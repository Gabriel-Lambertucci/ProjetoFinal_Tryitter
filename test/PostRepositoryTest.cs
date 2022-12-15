using projetofinal_tryitter.Models;
using projetofinal_tryitter.Repository;

namespace projetofinal_tryitter.test;

public class PostRepositoryTest
{
    [Theory]
    [MemberData(nameof(ShouldGetPosts))]
    public void ShouldGetPosts(TryitterContext context, int expected)
    {
      using(context) {
        var repository = new TryitterRepository(context);
        var result = repository.GetPosts();
        result.Length().Should().Be(expected);
      }
    }
    public readonly static TheoryData<TryitterContext>, List<Usuario> ShouldGetPosts =
      new()
      {
      {
        Helpers.GetContextInstanceForTests("ShouldGetPosts"),
        3
      },
      };

    [Theory]
    [MemberData(nameof(ShouldGetPosts))]
    public void ShouldAddPost(TryitterContext context, Post post, int expected)
    {
      using(context) {
        var repository = new TryitterRepository(context);
        repository.AddUsuario(post);
        var result = repository.GetPosts();
        result.Length().Should().Be(expected);
      }
    }
    public readonly static TheoryData<TryitterContext>, List<Post> ShouldGetPosts =
      new()
      {
      {
        Helpers.GetContextInstanceForTests("ShouldGetPosts"),
        new Post() {
            Texto = "Meu quarto texto",
            ImagemId = 4,
            UsuarioId = 4,
        },
        4
      },
      };
}