namespace Entities
{
    public partial class ProfesorAsignatura
    {
        public int ProfesorAsignaturaId { get; set; }

        public int ProfesorId { get; set; }

        public int AsignaturaId { get; set; }

        public virtual Asignatura Asignatura { get; set; } = null!;

        public virtual Profesor Profesor { get; set; } = null!;
    }
}
