namespace Repositories
{

    using Entities;
    using RepositoryContracts;

    public class AsignaturaRepository(AppDbContext.UniversidadDbContext context) : IAsignaturaRepository
    {
        public Asignatura? GetSubjectById(int id)
        {
            return context.Asignaturas.Find(id);
        }
    }
}
