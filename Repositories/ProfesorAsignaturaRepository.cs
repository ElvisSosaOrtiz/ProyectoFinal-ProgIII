namespace Repositories
{
    using Entities;
    using Microsoft.EntityFrameworkCore;
    using RepositoryContracts;

    public class ProfesorAsignaturaRepository(AppDbContext.UniversidadDbContext context) : IProfesorAsignaturaRepository
    {

        public IQueryable<ProfesorAsignatura> GetProfesorAsignaturaProfesorId(int profesorId)
        {
            return context.ProfesorAsignaturas
                .Include(p => p.Asignatura)
                .ThenInclude(p => p.ProfesorAsignaturas)
                .ThenInclude(p => p.Profesor)
                .Where(s => s.ProfesorId == profesorId);
        }
    }
}
