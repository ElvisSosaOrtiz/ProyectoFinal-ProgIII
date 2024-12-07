namespace Shared.Routing
{
    public class ProfesorAsignaturaControllerRoutes
    {
        public const string Root = "api/profesor-asignatura";

        public static string GetProfesorAsignaturaProfesorId(int id) => $"{Root}/{id}";

    }
}
