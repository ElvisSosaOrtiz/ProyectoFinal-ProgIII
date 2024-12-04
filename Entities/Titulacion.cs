namespace Entities
{
    using System.Collections.Generic;

    public class Titulacion
    {
        public int IdTitulacion { get; set; }

        public string Nombre { get; set; } = null!;

        public string? Descripcion { get; set; }

        public int? Duracion { get; set; }

        public virtual ICollection<Asignatura> Asignaturas { get; set; } = new List<Asignatura>();
    }
}
