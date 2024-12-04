namespace RepositoryContracts
{
    using Entities;

    public interface IAsignaturaRepository
    {
        Asignatura? GetSubjectById(int id);
    }
}
