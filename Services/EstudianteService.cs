namespace Services
{
    using Entities;
    using Microsoft.Extensions.Logging;
    using RepositoryContracts;
    using ServiceContracts;
    using Shared.Request;
    using Shared.Response;

    public class EstudianteService(
        IEstudianteRepository repository,
        ILogger<EstudianteService> logger) : IEstudianteService
    {
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
                    Titulacion = new() { Nombre = request.Nombre }
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
