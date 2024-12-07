namespace Shared.Response
{
    public class ResponseOfGetEstudianteAsignatura
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public decimal? Calificacion { get; set; }
        public int Creditos { get; set; }
        public string Codigo { get; set; } = null!;
        public string Profesor { get; set; } = null!;

        public int ProfesorId { get; set; }
        public string DiaSemana1 { get; set; } = null!;
        public string? DiaSemana2 { get; set; }
        public TimeOnly HoraInicio1 { get; set; }
        public TimeOnly HoraFin1 { get; set; }
        public TimeOnly? HoraInicio2 { get; set; }
        public TimeOnly? HoraFin2 { get; set; }
    }
}
