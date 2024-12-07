namespace Shared.Response
{
    public class ResponseOfGetAsignatura
    {
        public static readonly ResponseOfGetAsignatura Empty = new();

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public int Creditos { get; set; }
        public string Titulacion { get; set; } = null!;
        public string Codigo { get; set; } = null!;
        public int CreditosTeoricos { get; set; }
        public int? CreditosLaboratorios { get; set; }
        public string DiaSemana1 { get; set; } = null!;
        public string? DiaSemana2 { get; set; }
        public TimeOnly HoraInicio1 { get; set; }
        public TimeOnly HoraFin1 { get; set; }
        public TimeOnly? HoraInicio2 { get; set; }
        public TimeOnly? HoraFin2 { get; set; }
        public IEnumerable<ResponseOfGetProfesor> Profesores { get; set; } = [];
    }
}
