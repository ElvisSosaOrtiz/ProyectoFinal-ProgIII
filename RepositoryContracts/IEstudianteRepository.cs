namespace RepositoryContracts
{
    using Entities;

    public interface IEstudianteRepository
    {
        Estudiante? GetUserById(int userId);
        void AddAndSaveUser(Estudiante usuario);
    }
}
