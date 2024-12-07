namespace ServiceContracts
{
    using Shared.Response;
    using System.Collections.Generic;

    public interface IAsignaturaService
    {
        IEnumerable<ResponseOfGetAsignatura> GetAllAsignaturas();
        ResponseOfGetAsignatura GetAsignaturaById(int id);
    }
}
