namespace Entities
{
    public partial class AreaConocimiento
    {
        public int AreaConocimientoId { get; set; }

        public string Nombre { get; set; } = null!;

        public int TitulacionId { get; set; }

        public virtual Titulacion Titulacion { get; set; } = null!;
    }
}
