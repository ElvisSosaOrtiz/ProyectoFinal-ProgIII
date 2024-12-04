namespace Entities
{
    using System;

    public class Calificacion
    {
        public int IdCalificacion { get; set; }

        public int? IdEstudiante { get; set; }

        public int? IdAsignatura { get; set; }

        public int? IdCuatrimestre { get; set; }

        public decimal? PrimerParcial { get; set; }

        public decimal? SegundoParcial { get; set; }

        public decimal? ExamenFinal { get; set; }

        public decimal? Asistencia { get; set; }

        public DateOnly? FechaRegistro { get; set; }

        public virtual Asignatura? IdAsignaturaNavigation { get; set; }

        public virtual Cuatrimestre? IdCuatrimestreNavigation { get; set; }

        public virtual Usuario? IdEstudianteNavigation { get; set; }
    }
}
