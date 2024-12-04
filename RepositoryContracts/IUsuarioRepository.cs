namespace RepositoryContracts
{
    using Entities;

    public interface IUsuarioRepository
    {
        Usuario? GetUserById(int userId);
        void AddAndSaveUser(Usuario usuario);
    }
}
