using projetofinal_tryitter.Models;

namespace projetofinal_tryitter.Repository
{
  public class TryitterRepository: ITryitterRepository
  {
    private readonly ITryitterContext _context; 
    public TryitterRepository(ITryitterContext context){
      _context = context;
    }

    public IEnumerable<Post> GetPosts(){
      var posts = _context.Posts;
      return posts;
    }

    public Post GetPost(){
      var post = _context.Posts.LastOrDefault();
      return post;
    }

    public async void AddPost(Post post){
      await _context.Posts.AddAsync(post);
      _context.SaveChanges();
    }

    public async void AddRangePost(List<Post> posts){
      await _context.Posts.AddRangeAsync(posts);
      _context.SaveChanges();
    }

    public async void AddUsuario(Usuario usuario){
      await _context.Usuarios.AddAsync(usuario);
      _context.SaveChanges();
    }

    public async void AddRangeUsuario(List<Usuario> usuarios){
      await _context.Usuarios.AddRangeAsync(usuarios);
      _context.SaveChanges();
    }

    public IEnumerable<Usuario> GetUsuarios(){
      var usuarios = _context.Usuarios;
      return usuarios;
    }
  }
}