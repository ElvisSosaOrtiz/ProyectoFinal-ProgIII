namespace Shared.Response
{
    public class ResponseOfGetProfesorAsignaturaProfesorId
    {
        public static readonly ResponseOfGetProfesorAsignaturaProfesorId Empty = new();

        public int ProfesorId { get; set; }
        public int AsignaturaId { get; set; }

        public string NombreAsignatura { get; set; } = null!;

        public string AsignaturaCodigo { get; set; } = null!;
        public int CreditosTeoricos { get; set; }
        public string DiaSemana1 { get; set; } = null!;
        public string? DiaSemana2 { get; set; }
        public TimeOnly HoraInicio1 { get; set; }
        public TimeOnly HoraFin1 { get; set; }
        public TimeOnly? HoraInicio2 { get; set; }
        public TimeOnly? HoraFin2 { get; set; }


    }
}
