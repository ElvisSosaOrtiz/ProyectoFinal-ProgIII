namespace Entities
{
    using System.Collections.Generic;

    public class Asignatura
    {
        public int IdAsignatura { get; set; }

        public string Nombre { get; set; } = null!;

        public int Creditos { get; set; }

        public int? Semestre { get; set; }

        public int? IdTitulacion { get; set; }

        public string Codigo { get; set; } = null!;

        public int CreditosTeoricos { get; set; }

        public int? CreditosLaboratorio { get; set; }

        public bool LibreConfiguracion { get; set; }

        public virtual ICollection<Calificacion> Calificacions { get; set; } = new List<Calificacion>();

        public virtual ICollection<EstudianteAsignatura> EstudianteAsignaturas { get; set; } = new List<EstudianteAsignatura>();

        public virtual Titulacion? IdTitulacionNavigation { get; set; }

        public virtual ICollection<Usuario> IdProfesors { get; set; } = new List<Usuario>();
    }
}
