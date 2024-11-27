namespace OrdenesPPI.Web.Models
{
    public class ActivoModel
    {
        public int Id { get; set; }
        public string Ticker { get; set; }

        public string Nombre { get; set; }

        public decimal PrecioUnitario { get; set; }

        public int TipoActivoId { get; set; }
    }
}
