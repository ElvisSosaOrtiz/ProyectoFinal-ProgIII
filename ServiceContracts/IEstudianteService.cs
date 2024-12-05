namespace ServiceContracts
{
    using Shared.Request;
    using Shared.Response;

    public interface IEstudianteService
    {
        ResponseOfGetStudent GetStudentById(int studentId);
        void RegisterStudent(RequestOfRegisterStudent request);
    }
}
