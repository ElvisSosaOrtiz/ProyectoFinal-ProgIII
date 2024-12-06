namespace Repositories
{
    using Entities;
    using Microsoft.EntityFrameworkCore;
    using Repositories.AppDbContext;
    using RepositoryContracts;

    public class ProfesorRepository : IProfesorRepository
    {
        private readonly UniversidadDbContext _context;

        public ProfesorRepository(UniversidadDbContext context)
        {
            _context = context;
        }

        public Profesor? GetProfesor(int id)
        {
            return _context.Profesors
                .Include(p => p.Titulacion)
                .FirstOrDefault(x => x.ProfesorId == id);
        }
    }
}
