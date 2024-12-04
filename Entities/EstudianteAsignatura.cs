namespace Entities
{
    using System;

    public class EstudianteAsignatura
    {
        public int IdEstudiante { get; set; }

        public int IdAsignatura { get; set; }

        public int IdCuatrimestre { get; set; }

        public DateOnly? FechaInscripcion { get; set; }

        public virtual Asignatura IdAsignaturaNavigation { get; set; } = null!;

        public virtual Cuatrimestre IdCuatrimestreNavigation { get; set; } = null!;

        public virtual Usuario IdEstudianteNavigation { get; set; } = null!;
    }
}
