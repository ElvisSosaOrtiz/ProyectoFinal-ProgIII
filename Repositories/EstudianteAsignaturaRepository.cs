namespace Repositories
{
    using Entities;
    using RepositoryContracts;

    public class EstudianteAsignaturaRepository(AppDbContext.UniversidadDbContext context) : IEstudianteAsignaturaRepository
    {
        public void AddAndSaveStudentSubjects(List<EstudianteAsignatura> estudianteAsignatura)
        {
            context.EstudianteAsignaturas.AddRange(estudianteAsignatura);
            context.SaveChanges();
        }

        public IQueryable<EstudianteAsignatura> GetStudentSubjectsByStudentId(int studentId)
        {
            return context.EstudianteAsignaturas.Where(s => s.EstudianteId == studentId);
        }

        public void RemoveAndSaveStudentSubject(int studentSubjectId)
        {
            var estudianteAsignatura = context.EstudianteAsignaturas.Find(studentSubjectId)!;
            context.EstudianteAsignaturas.Remove(estudianteAsignatura);
        }
    }
}
