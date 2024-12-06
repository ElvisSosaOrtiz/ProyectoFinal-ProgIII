namespace RepositoryContracts
{
    using Entities;

    public interface IProfesorRepository
    {
        Profesor? GetProfesor(int id);
    }
}
