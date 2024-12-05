namespace Entities
{
    public partial class EstudianteAsignatura
    {
        public int EstudianteAsignaturaId { get; set; }

        public int AsignaturaId { get; set; }

        public int EstudianteId { get; set; }

        public decimal? Calificacion { get; set; }

        public virtual Asignatura Asignatura { get; set; } = null!;

        public virtual Estudiante Estudiante { get; set; } = null!;
    }
}
