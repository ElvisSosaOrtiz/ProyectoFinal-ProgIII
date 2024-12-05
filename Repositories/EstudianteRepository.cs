namespace Repositories
{
    using Entities;
    using Api.AppDbContext;
    using RepositoryContracts;

    public class EstudianteRepository(UniversidadDbContext context) : IEstudianteRepository
    {
        public Estudiante? GetUserById(int userId)
        {
            return context.Estudiantes.Find(userId);
        }

        public void AddAndSaveUser(Estudiante Estudiante)
        {
            context.Estudiantes.Add(Estudiante);
            context.SaveChanges();
        }
    }
}
