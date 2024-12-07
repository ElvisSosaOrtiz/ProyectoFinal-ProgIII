namespace Client.ViewModels
{
    using System.ComponentModel.DataAnnotations;

    public class EstudianteViewModel
    {
        [Required]
        public string Nombre { get; set; } = null!;

        [Required]
        public string Apellidos { get; set; } = null!;

        [Required]
        public string Username { get; set; } = null!;

        [Required]
        public string Password { get; set; } = null!;

        [Required]
        public string Email { get; set; } = null!;

        [Required]
        public string? Telefono { get; set; }
    }
}
