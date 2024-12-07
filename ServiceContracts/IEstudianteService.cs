namespace ServiceContracts
{
    using Shared.Request;
    using Shared.Response;

    public interface IEstudianteService
    {
        ResponseOfGetEstudiante GetStudentById(int studentId);
        void RegisterStudent(RequestOfRegisterStudent request);
    }
}
