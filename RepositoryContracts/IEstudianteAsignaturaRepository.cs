namespace RepositoryContracts
{
    using Entities;

    public interface IEstudianteAsignaturaRepository
    {
        IQueryable<EstudianteAsignatura> GetStudentSubjectsByStudentId(int studentId);

        void AddAndSaveStudentSubject(EstudianteAsignatura estudianteAsignatura);

        void RemoveAndSaveStudentSubject(int studentSubjectId);
    }
}
