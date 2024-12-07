namespace Services
{
    using Entities;
    using Microsoft.Extensions.Logging;
    using RepositoryContracts;
    using ServiceContracts;
    using Shared.Response;
    using System.Collections.Generic;

    public class EstudianteAsignaturaService : IEstudianteAsignaturaService
    {
        private readonly IEstudianteAsignaturaRepository _estudianteAsignaturaRepository;
        private readonly IAsignaturaRepository _asignaturaRepository;
        private readonly ILogger<EstudianteAsignaturaService> _logger;

        public EstudianteAsignaturaService(
            IEstudianteAsignaturaRepository repository,
            IAsignaturaRepository asignaturaRepository,
            ILogger<EstudianteAsignaturaService> logger)
        {
            _estudianteAsignaturaRepository = repository;
            _asignaturaRepository = asignaturaRepository;
            _logger = logger;
        }

        public void AddAsignatura(List<int> idAsignaturas, int idEstudiante)
        {
            try
            {
                var selectedAsignaturas = _asignaturaRepository.QueryAllAsignaturas()
                    .Where(a => idAsignaturas.Any(id => id == a.AsignaturaId))
                    .Select(a => new EstudianteAsignatura
                    {
                        AsignaturaId = a.AsignaturaId,
                        EstudianteId = idEstudiante
                    });

                _estudianteAsignaturaRepository.AddAndSaveStudentSubjects(selectedAsignaturas);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
            }
        }

        public IEnumerable<ResponseOfGetEstudianteAsignatura> GetAsignaturasEstudiante(int idEstudiante)
        {
            try
            {
                return _estudianteAsignaturaRepository.GetStudentSubjectsByStudentId(idEstudiante)
                    .Select(a => new ResponseOfGetEstudianteAsignatura
                    {
                        Id = a.Asignatura.AsignaturaId,
                        Nombre = a.Asignatura.Nombre,
                        Creditos = a.Asignatura.Creditos,
                        Codigo = a.Asignatura.Codigo,
                        Calificacion = a.Calificacion,
                        DiaSemana1 = a.Asignatura.DiaSemana1,
                        DiaSemana2 = a.Asignatura.DiaSemana2,
                        HoraInicio1 = a.Asignatura.HoraInicio1,
                        HoraInicio2 = a.Asignatura.HoraInicio2,
                        HoraFin1 = a.Asignatura.HoraFin1,
                        HoraFin2 = a.Asignatura.HoraFin2,
                        Profesor = NombreProfesor(a)
                    });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return [];
            }
        }

        private static string NombreProfesor(EstudianteAsignatura asignatura)
        {
            var profesor = asignatura.Asignatura.ProfesorAsignaturas
                .First(x => x.AsignaturaId == asignatura.AsignaturaId).Profesor;

            return $"{profesor.Nombre} {profesor.Apellido}";
        }

        public void RemoveAsignatura(List<int> idAsignaturas)
        {
            try
            {
                _estudianteAsignaturaRepository.RemoveAndSaveStudentSubjects(idAsignaturas);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
            }
        }
    }
}
