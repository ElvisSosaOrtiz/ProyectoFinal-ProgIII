namespace RepositoryContracts
{
    using Entities;

    public interface IEstudianteAsignaturaRepository
    {
        IQueryable<EstudianteAsignatura> GetStudentSubjectsByStudentId(int studentId);
        void AddAndSaveStudentSubjects(IQueryable<EstudianteAsignatura> estudianteAsignatura);
        void RemoveAndSaveStudentSubjects(List<int> studentSubjectIds);
    }
}
