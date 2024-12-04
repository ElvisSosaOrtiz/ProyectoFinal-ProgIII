namespace RepositoryContracts
{
    using Entities;

    public interface ICalificacionRepository
    {
        IQueryable<Calificacion> GetScoresByStudentAndPeriodId(int studentId, int periodId);
    }
}
