namespace Client.Routing
{
    public class ClientRoutes
    {
        public const string Login = "/";
        public const string Register = "/register";
        public const string Asignatura = "/asignatura";
        public const string Profesor = "/profesor";

        public static string NavigateToAsignatura(int id) => $"{Asignatura}/{id}";
        public static string NavigateToProfesor(int id) => $"{Profesor}/{id}";
    }
}
