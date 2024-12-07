namespace Shared.Routing
{
    public class ProfesorControllerRoutes
    {
        public const string Root = "api/profesor";

        public static string GetProfesorId(int id) => $"{Root}/{id}";

    }
}
