namespace Services
{
    using Entities;
    using Microsoft.Extensions.Logging;
    using RepositoryContracts;
    using ServiceContracts;
    using Shared.Response;
    using System.Collections.Generic;

    public class ProfesorAsignaturaService : IProfesorAsignaturaService
    {
        private readonly IProfesorAsignaturaRepository _profesorAsignaturaRepository;
        private readonly IAsignaturaRepository _asignaturaRepository;
        private readonly ILogger<EstudianteAsignaturaService> _logger;

        public ProfesorAsignaturaService(
            IProfesorAsignaturaRepository repository,
            IAsignaturaRepository asignaturaRepository,
            ILogger<EstudianteAsignaturaService> logger)
        {
            _profesorAsignaturaRepository = repository;
            _asignaturaRepository = asignaturaRepository;
            _logger = logger;
        }


        public IEnumerable<ResponseOfGetProfesorAsignaturaProfesorId> GetProfesorAsignaturaByProfesorId(int id)
        {

            try
            {
                return _profesorAsignaturaRepository.GetProfesorAsignaturaProfesorId(id)
                    .Select(a => new ResponseOfGetProfesorAsignaturaProfesorId
                    {
                        ProfesorId = a.ProfesorId,
                        AsignaturaId = a.AsignaturaId,
                        NombreAsignatura = a.Asignatura.Nombre,
                        AsignaturaCodigo = a.Asignatura.Codigo,
                        CreditosTeoricos = a.Asignatura.CreditosTeoricos,
                        DiaSemana1 = a.Asignatura.DiaSemana1,
                        DiaSemana2 = a.Asignatura.DiaSemana2,
                        HoraInicio1 = a.Asignatura.HoraInicio1,
                        HoraFin1 = a.Asignatura.HoraFin1,
                        HoraInicio2 = a.Asignatura.HoraInicio2,
                        HoraFin2 = a.Asignatura.HoraFin2
                    });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return [];
            }
        }
    }
}
