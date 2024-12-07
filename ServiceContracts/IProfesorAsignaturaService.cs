namespace ServiceContracts
{
    using Shared.Response;

    public interface IProfesorAsignaturaService
    {
        IEnumerable<ResponseOfGetProfesorAsignaturaProfesorId> GetProfesorAsignaturaByProfesorId(int id);
    }
}
