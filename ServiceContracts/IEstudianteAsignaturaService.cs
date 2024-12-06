namespace ServiceContracts
{
    using Shared.Response;

    public interface IEstudianteAsignaturaService
    {
        void AddAsignatura(List<int> idAsignaturas, int idEstudiante);
        IEnumerable<ResponseOfGetEstudianteAsignatura> GetAsignaturasEstudiante(int idEstudiante);
        void RemoveAsignatura(List<int> idAsignaturas);
    }
}
