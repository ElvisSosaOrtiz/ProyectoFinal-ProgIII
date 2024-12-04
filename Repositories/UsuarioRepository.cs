namespace Repositories
{
    using Api.AppDbContext;
    using Entities;
    using RepositoryContracts;

    public class UsuarioRepository(UniversidadContext context) : IUsuarioRepository
    {
        public Usuario? GetUserById(int userId)
        {
            return context.Usuarios.Find(userId);
        }

        public void AddAndSaveUser(Usuario usuario)
        {
            context.Usuarios.Add(usuario);
            context.SaveChanges();
        }
    }
}
