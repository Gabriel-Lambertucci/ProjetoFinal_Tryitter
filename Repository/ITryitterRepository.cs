using projetofinal_tryitter.Models;

namespace projetofinal_tryitter.Repository
{
  public interface ITryitterRepository
  {
    IEnumerable<Post> GetPosts();
    Post GetPost();
    void AddPost(Post post);

    void AddRangePost(List<Post> posts);
    void AddUsuario(Usuario usuario);
    void AddRangeUsuario(List<Usuario> usuarios);
    IEnumerable<Usuario> GetUsuarios();
  }
}