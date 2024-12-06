namespace Repositories
{
    using Entities;
    using RepositoryContracts;

    public class EstudianteRepository(AppDbContext.UniversidadDbContext context) : IEstudianteRepository
    {
        public Estudiante? GetStudentById(int userId)
        {
            return context.Estudiantes.Find(userId);
        }

        public void AddAndSaveStudent(Estudiante Estudiante)
        {
            context.Estudiantes.Add(Estudiante);
            context.SaveChanges();
        }
    }
}
