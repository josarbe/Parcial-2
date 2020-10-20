namespace PruebaAPI.Models
{
    public class Respuesta
    {
        public string estatus { get; set; }
        public string detalle { get; set; }
        public Usuario usuario { get; set; }
    }
}