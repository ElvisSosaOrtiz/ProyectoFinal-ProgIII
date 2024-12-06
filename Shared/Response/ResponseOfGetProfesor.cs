namespace Shared.Response
{
    public class ResponseOfGetProfesor
    {
        public static readonly ResponseOfGetProfesor Empty = new();

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Titulacion { get; set; } = null!;
    }
}
