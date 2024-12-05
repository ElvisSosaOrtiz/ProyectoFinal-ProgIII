namespace RepositoryContracts
{
    using Entities;

    public interface IEstudianteAsignaturaRepository
    {
        IQueryable<EstudianteAsignatura> GetStudentSubjectsByStudentId(int studentId);
        void AddAndSaveStudentSubjects(List<EstudianteAsignatura> estudianteAsignatura);
        void RemoveAndSaveStudentSubject(int studentSubjectId);
    }
}
