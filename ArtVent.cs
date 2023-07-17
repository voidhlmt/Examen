namespace ExamenAPI.Models
{
    public class ArtVent
    {
        public int codigo { get; set; } = 0;
        public string nombre { get; set; } = string.Empty;
        public int precio { get; set; } = 0;
        public int existencia { get; set; } = 0;
        public int factura { get; set; } = 0;
        public DateTime fecha { get; set; } = DateTime.MinValue;
        public int total { get; set; } = 0;




    }
}
