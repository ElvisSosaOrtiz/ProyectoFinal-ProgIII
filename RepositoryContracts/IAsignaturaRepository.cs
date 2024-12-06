namespace RepositoryContracts
{
    using Entities;
    using System.Linq;

    public interface IAsignaturaRepository
    {
        Asignatura? GetSubjectById(int id);
        IQueryable<Asignatura> QueryAllAsignaturas();
    }
}
