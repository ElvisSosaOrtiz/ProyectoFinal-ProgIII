namespace Shared.Response
{
    public class ResponseOfGetEstudiante
    {
        public static readonly ResponseOfGetEstudiante Empty = new();

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Apellidos { get; set; } = null!;
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string? Email { get; set; }
        public string? Telefono { get; set; }
        public string Titulacion { get; set; } = null!;
    }
}
