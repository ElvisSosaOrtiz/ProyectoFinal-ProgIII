namespace Services
{
    using Entities;
    using Microsoft.Extensions.Logging;
    using RepositoryContracts;
    using ServiceContracts;
    using Shared.Request;
    using Shared.Response;

    public class EstudianteService : IEstudianteService
    {
        private readonly IEstudianteRepository repository;
        private readonly ILogger<EstudianteService> logger;

        public EstudianteService(IEstudianteRepository repository, ILogger<EstudianteService> logger)
        {
            this.repository = repository;
            this.logger = logger;
        }

        public ResponseOfGetStudent GetStudentById(int studentId)
        {
            try
            {
                var student = repository.GetStudentById(studentId);
                if (student is null) throw new ApplicationException("Student should not be null");

                return new()
                {
                    Id = student.EstudianteId,
                    Nombre = student.Nombre,
                    Apellidos = student.Apellidos,
                    Email = student.Email,
                    Telefono = student.Telefono,
                    Titulacion = student.Titulacion.Nombre
                };
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
                return ResponseOfGetStudent.Empty;
            }
        }

        public void RegisterStudent(RequestOfRegisterStudent request)
        {
            try
            {
                var student = new Estudiante
                {
                    Nombre = request.Nombre,
                    Apellidos = request.Apellidos,
                    Email = request.Email,
                    Telefono = request.Telefono,
                    TitulacionId =  request.TitulacionId,
                    TipoUsuario = 1
                };

                repository.AddAndSaveStudent(student);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
            }
        }
    }
}
