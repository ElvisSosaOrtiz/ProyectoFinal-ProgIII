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

        public IEnumerable<ResponseOfGetAsignatura> GetAllAsignaturas()
        {
            try
            {
                return _repository.QueryAllAsignaturas()
                    .Select(a => new ResponseOfGetAsignatura
                    {
                        Id = a.AsignaturaId,
                        Nombre = a.Nombre,
                        Codigo = a.Codigo,
                        Creditos = a.Creditos,
                        CreditosTeoricos = a.CreditosTeoricos,
                        CreditosLaboratorios = a.CreditosLaboratorio,
                        Titulacion = a.Titulacion.Nombre,
                        DiaSemana1 = a.DiaSemana1,
                        DiaSemana2 = a.DiaSemana2,
                        HoraInicio1 = a.HoraInicio1,
                        HoraFin1 = a.HoraFin1,
                        HoraInicio2 = a.HoraInicio2,
                        HoraFin2 = a.HoraFin2,
                        Profesores = a.ProfesorAsignaturas.Select(p => new ResponseOfGetProfesor
                        {
                            Id = p.ProfesorId,
                            Nombre = p.Profesor.Nombre,
                            Apellido = p.Profesor.Apellido,
                            Email = p.Profesor.Email,
                            Titulacion = p.Profesor.Titulacion.Nombre
                        })
                    });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return [];
            }
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
                    Profesores = asignatura.ProfesorAsignaturas.Select(p => new ResponseOfGetProfesor
                    {
                        Id = p.ProfesorId,
                        Nombre = p.Profesor.Nombre,
                        Apellido = p.Profesor.Apellido,
                        Email = p.Profesor.Email,
                        Titulacion = p.Profesor.Titulacion.Nombre
                    })
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
