namespace RepositoryContracts
{
    using Entities;

    public interface IEstudianteRepository
    {
        Estudiante? GetStudentById(int userId);
        void AddAndSaveStudent(Estudiante usuario);
    }
}
