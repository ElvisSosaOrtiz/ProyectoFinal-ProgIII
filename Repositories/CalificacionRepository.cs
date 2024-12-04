namespace Repositories
{
    using Api.AppDbContext;
    using Entities;
    using RepositoryContracts;
    using System.Linq;

    public class CalificacionRepository(UniversidadContext context) : ICalificacionRepository
    {
        public IQueryable<Calificacion> GetScoresByStudentAndPeriodId(int studentId, int periodId)
        {
            return context.Calificacions
                .Where(c => c.IdEstudiante == studentId)
                .Where(c => c.IdCuatrimestre == periodId);
        }
    }
}
