using projetofinal_tryitter.Models;
using projetofinal_tryitter.Repository;

namespace projetofinal_tryitter.test;

public class UserRepositoryTest
{
    [Theory]
    [MemberData(nameof(ShouldGetUsuarios))]
    public void ShouldGetUsuarios(TryitterContext context, int expected)
    {
      using(context) {
        var repository = new TryitterRepository(context);
        var result = repository.GetUsuarios();
        result.Length().Should().Be(expected);
      }
    }
    public readonly static TheoryData<TryitterContext>, List<Usuario> ShouldGetUsuarios =
      new()
      {
      {
        Helpers.GetContextInstanceForTests("ShouldGetUsuarios"),
        3
      },
      };

    [Theory]
    [MemberData(nameof(ShouldGetUsuarios))]
    public void ShouldAddUsuario(TryitterContext context, Usuario usuario, int expected)
    {
      using(context) {
        var repository = new TryitterRepository(context);
        repository.AddUsuario(usuario);
        var result = repository.GetUsuarios();
        result.Length().Should().Be(expected);
      }
    }
    public readonly static TheoryData<TryitterContext>, List<Usuario> ShouldGetUsuarios =
      new()
      {
      {
        Helpers.GetContextInstanceForTests("ShouldGetUsuarios"),
        new Usuario() {
            Nome = "Celso",
            Email = "",
            Senha = "",
            Status = ""
        },
        3
      },
      };
}