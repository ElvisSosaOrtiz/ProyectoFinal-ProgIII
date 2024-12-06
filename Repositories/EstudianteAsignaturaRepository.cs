namespace Repositories
{
    using Entities;
    using Microsoft.EntityFrameworkCore;
    using RepositoryContracts;

    public class EstudianteAsignaturaRepository(AppDbContext.UniversidadDbContext context) : IEstudianteAsignaturaRepository
    {
        public void AddAndSaveStudentSubjects(IQueryable<EstudianteAsignatura> estudianteAsignatura)
        {
            context.EstudianteAsignaturas.AddRange(estudianteAsignatura);
            context.SaveChanges();
        }

        public IQueryable<EstudianteAsignatura> GetStudentSubjectsByStudentId(int studentId)
        {
            return context.EstudianteAsignaturas
                .Include(p => p.Asignatura)
                .ThenInclude(p => p.ProfesorAsignaturas)
                .ThenInclude(p => p.Profesor)
                .Where(s => s.EstudianteId == studentId);
        }

        public void RemoveAndSaveStudentSubjects(List<int> studentSubjectIds)
        {
            var estudianteAsignaturas = context.EstudianteAsignaturas
                .Where(a => studentSubjectIds.Any(id => id == a.EstudianteAsignaturaId));

            context.EstudianteAsignaturas.RemoveRange(estudianteAsignaturas);
            context.SaveChanges();
        }
    }
}
