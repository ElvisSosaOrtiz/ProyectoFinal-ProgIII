namespace Repositories
{
    using Entities;
    using Microsoft.EntityFrameworkCore;
    using RepositoryContracts;

    public class AsignaturaRepository(AppDbContext.UniversidadDbContext context) : IAsignaturaRepository
    {
        public Asignatura? GetSubjectById(int id)
        {
            return context.Asignaturas
                .Include(x => x.Titulacion)
                .Include(x => x.ProfesorAsignaturas)
                .ThenInclude(p => p.Profesor)
                .FirstOrDefault(a => a.AsignaturaId == id);
        }

        public IQueryable<Asignatura> QueryAllAsignaturas()
        {
            return context.Asignaturas
                .Include(x => x.Titulacion)
                .Include(x => x.ProfesorAsignaturas)
                .ThenInclude(p => p.Profesor);
        }
    }
}
