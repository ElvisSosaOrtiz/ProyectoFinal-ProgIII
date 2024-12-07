namespace Shared.Routing
{
    public class EstudianteAsignaturaControllerRoutes
    {
        public const string Root = "api/estudiante-asignatura";

        public static string GetEstudianteAsignaturas(int id) => $"{Root}/{id}";
    }
}
