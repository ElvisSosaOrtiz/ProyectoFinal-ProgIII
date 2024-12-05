namespace Entities
{
    public partial class Asignatura
    {
        public int AsignaturaId { get; set; }

        public string Nombre { get; set; } = null!;

        public int Creditos { get; set; }

        public int TitulacionId { get; set; }

        public string Codigo { get; set; } = null!;

        public int CreditosTeoricos { get; set; }

        public int? CreditosLaboratorio { get; set; }

        public string DiaSemana1 { get; set; } = null!;

        public string? DiaSemana2 { get; set; }

        public TimeOnly HoraInicio1 { get; set; }

        public TimeOnly HoraFin1 { get; set; }

        public TimeOnly? HoraInicio2 { get; set; }

        public TimeOnly? HoraFin2 { get; set; }

        public virtual ICollection<EstudianteAsignatura> EstudianteAsignaturas { get; set; } = new List<EstudianteAsignatura>();

        public virtual ICollection<ProfesorAsignatura> ProfesorAsignaturas { get; set; } = new List<ProfesorAsignatura>();

        public virtual Titulacion Titulacion { get; set; } = null!;
    }
}
