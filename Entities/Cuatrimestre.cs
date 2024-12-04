namespace Entities
{
    using System.Collections.Generic;

    public class Cuatrimestre
    {
        public int IdCuatrimestre { get; set; }

        public string Nombre { get; set; } = null!;

        public string? Codigo { get; set; }

        public virtual ICollection<Calificacion> Calificacions { get; set; } = new List<Calificacion>();

        public virtual ICollection<EstudianteAsignatura> EstudianteAsignaturas { get; set; } = new List<EstudianteAsignatura>();
    }
}
