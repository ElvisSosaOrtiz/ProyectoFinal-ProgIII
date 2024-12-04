namespace Entities
{
    using System.Collections.Generic;

    public class Usuario
    {
        public int IdUsuario { get; set; }

        public string Nombre { get; set; } = null!;

        public string? Apellidos { get; set; }

        public string? Email { get; set; }

        public string? Telefono { get; set; }

        public string? Departamento { get; set; }

        public string TipoUsuario { get; set; } = null!;

        public virtual ICollection<Calificacion> Calificacions { get; set; } = new List<Calificacion>();

        public virtual ICollection<EstudianteAsignatura> EstudianteAsignaturas { get; set; } = new List<EstudianteAsignatura>();

        public virtual ICollection<Asignatura> IdAsignaturas { get; set; } = new List<Asignatura>();
    }
}
