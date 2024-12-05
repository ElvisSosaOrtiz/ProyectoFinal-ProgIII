namespace Entities
{
    public partial class Profesor
    {
        public int ProfesorId { get; set; }

        public string Nombre { get; set; } = null!;

        public string Apellido { get; set; } = null!;

        public string Email { get; set; } = null!;

        public int TitulacionId { get; set; }

        public virtual ICollection<ProfesorAsignatura> ProfesorAsignaturas { get; set; } = new List<ProfesorAsignatura>();

        public virtual Titulacion Titulacion { get; set; } = null!;
    }
}
