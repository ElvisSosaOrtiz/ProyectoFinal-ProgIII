namespace Repositories
{
    using Api.AppDbContext;
    using Entities;
    using RepositoryContracts;

    public class EstudianteAsignaturaRepository(UniversidadContext context) : IEstudianteAsignaturaRepository
    {
        public void AddAndSaveStudentSubject(EstudianteAsignatura estudianteAsignatura)
        {
            context.EstudianteAsignaturas.Add(estudianteAsignatura);
            context.SaveChanges();
        }

        public IQueryable<EstudianteAsignatura> GetStudentSubjectsByStudentId(int studentId)
        {
            return context.EstudianteAsignaturas.Where(s => s.IdEstudiante == studentId);
        }

        public void RemoveAndSaveStudentSubject(int studentSubjectId)
        {
            var estudianteAsignatura = context.EstudianteAsignaturas.Find(studentSubjectId)!;
            context.EstudianteAsignaturas.Remove(estudianteAsignatura);
        }
    }
}
