namespace RepositoryContracts
{
    using Entities;

    public interface IProfesorAsignaturaRepository
    {
        IQueryable<ProfesorAsignatura> GetProfesorAsignaturaProfesorId(int profesorId);
    }
}
