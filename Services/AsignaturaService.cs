namespace Services
{
    using Microsoft.Extensions.Logging;
    using RepositoryContracts;
    using ServiceContracts;
    using Shared.Response;

    public class AsignaturaService : IAsignaturaService
    {
        private readonly IAsignaturaRepository _repository;
        private readonly ILogger<AsignaturaService> _logger;

        public AsignaturaService(
            IAsignaturaRepository repository,
            ILogger<AsignaturaService> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        public ResponseOfGetAsignatura GetAsignaturaById(int id)
        {
            try
            {
                var asignatura = _repository.GetSubjectById(id);
                if (asignatura is null) return ResponseOfGetAsignatura.Empty;

                return new()
                {
                    Id = asignatura.AsignaturaId,
                    Nombre = asignatura.Nombre,
                    Creditos = asignatura.Creditos,
                    Titulacion = asignatura.Titulacion.Nombre,
                    Codigo = asignatura.Codigo,
                    CreditosTeoricos = asignatura.CreditosTeoricos,
                    CreditosLaboratorios = asignatura.CreditosLaboratorio,
                    DiaSemana1 = asignatura.DiaSemana1,
                    DiaSemana2 = asignatura.DiaSemana2,
                    HoraInicio1 = asignatura.HoraInicio1,
                    HoraFin1 = asignatura.HoraFin1,
                    HoraInicio2 = asignatura.HoraFin2,
                    HoraFin2 = asignatura.HoraFin2,
                    Profesores = asignatura.ProfesorAsignaturas.Select(p => $"{p.Profesor.Nombre} {p.Profesor.Apellido}")
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return ResponseOfGetAsignatura.Empty;
            }
        }
    }
}
