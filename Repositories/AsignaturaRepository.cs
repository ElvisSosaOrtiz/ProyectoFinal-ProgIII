namespace Repositories
{
    using Api.AppDbContext;
    using Entities;
    using RepositoryContracts;

    public class AsignaturaRepository(UniversidadContext context) : IAsignaturaRepository
    {
        public Asignatura? GetSubjectById(int id)
        {
            return context.Asignaturas.Find(id);
        }
    }
}
