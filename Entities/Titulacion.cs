namespace Entities
{
    public partial class Titulacion
    {
        public int TitulacionId { get; set; }

        public string Nombre { get; set; } = null!;

        public string Encargado { get; set; } = null!;

        public virtual ICollection<AreaConocimiento> AreaConocimientos { get; set; } = new List<AreaConocimiento>();

        public virtual ICollection<Asignatura> Asignaturas { get; set; } = new List<Asignatura>();

        public virtual ICollection<Estudiante> Estudiantes { get; set; } = new List<Estudiante>();

        public virtual ICollection<Profesor> Profesors { get; set; } = new List<Profesor>();
    }
}
