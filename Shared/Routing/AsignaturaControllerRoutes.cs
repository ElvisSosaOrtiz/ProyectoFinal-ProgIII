namespace Shared.Routing
{
    public class AsignaturaControllerRoutes
    {
        public const string Root = "api/asignatura";

        public static string GetAllAsignaturas => $"{Root}";
        public static string GetAsignatura(int id) => $"{Root}/{id}";
    }
}
