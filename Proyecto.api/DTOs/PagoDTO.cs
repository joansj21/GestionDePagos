namespace Proyecto.api.DTOs
{
    public class PagoDTO
    {
        public string pan { get; set; }
        public string fechaVencimiento { get; set; }
        public string cvv { get; set; }
        public int commercio { get; set; }
        public int terminal { get; set; }
        public decimal Total { get; set; }
    }
}
