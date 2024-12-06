namespace ServiceContracts
{
    using Shared.Response;

    public interface IAsignaturaService
    {
        ResponseOfGetAsignatura GetAsignaturaById(int id);
    }
}
