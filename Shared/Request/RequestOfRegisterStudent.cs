namespace Shared.Request
{
    public class RequestOfRegisterStudent
    {
        public required string Nombre { get; set; } = null!;
        public required string Apellidos { get; set; } = null!;
        public string? Email { get; set; }
        public string? Telefono { get; set; }
        public required int TitulacionId { get; set; }
    }
}
