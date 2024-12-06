namespace Repositories
{
    using Entities;
    using Microsoft.EntityFrameworkCore;
    using RepositoryContracts;

    public class EstudianteRepository(AppDbContext.UniversidadDbContext context) : IEstudianteRepository
    {
        public Estudiante? GetStudentById(int userId)
        {
            return context.Estudiantes.Include(t => t.Titulacion).
                FirstOrDefault(e => e.EstudianteId == userId);
        }

        public void AddAndSaveStudent(Estudiante Estudiante)
        {
            context.Estudiantes.Add(Estudiante);
            context.SaveChanges();
        }
    }
}
