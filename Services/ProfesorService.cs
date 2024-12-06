namespace Services
{
    using Microsoft.Extensions.Logging;
    using RepositoryContracts;
    using ServiceContracts;
    using Shared.Response;

    public class ProfesorService : IProfesorService
    {
        private readonly IProfesorRepository _repository;
        private readonly ILogger<ProfesorService> _logger;

        public ProfesorService(
            IProfesorRepository repository,
            ILogger<ProfesorService> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        public ResponseOfGetProfesor GetProfesorById(int id)
        {
            try
            {
                var profesor = _repository.GetProfesor(id);
                if (profesor is null) return ResponseOfGetProfesor.Empty;

                return new()
                {
                    Id = profesor.ProfesorId,
                    Nombre = profesor.Nombre,
                    Apellido = profesor.Apellido,
                    Email = profesor.Email,
                    Titulacion = profesor.Titulacion.Nombre
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return ResponseOfGetProfesor.Empty;
            }
        }
    }
}
