namespace ServiceContracts
{
    using Shared.Response;

    public interface IProfesorService
    {
        ResponseOfGetProfesor GetProfesorById(int id);
    }
}
