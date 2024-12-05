namespace Entities
{
    public partial class Estudiante
    {
        public int EstudianteId { get; set; }

        public string Nombre { get; set; } = null!;

        public string Apellidos { get; set; } = null!;

        public string? Email { get; set; }

        public string? Telefono { get; set; }

        public int TipoUsuario { get; set; }

        public int TitulacionId { get; set; }

        public virtual ICollection<EstudianteAsignatura> EstudianteAsignaturas { get; set; } = new List<EstudianteAsignatura>();

        public virtual Titulacion Titulacion { get; set; } = null!;
    }
}
