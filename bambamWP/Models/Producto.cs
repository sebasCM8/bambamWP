namespace bambamWP.Models
{
    public class Producto
    {
        public int proId { get; set; } = 0;
        public string proNombre { get; set; } = "";
        public string proDesc { get; set; } = "";
        public decimal proPrecio { get; set; } = 0;
        public int proUni { get; set; } = 0;
        public int proCat { get; set; } = 0;
        public int proEstado { get; set; } = 0;
        public string proUniNombre { get; set; } = "";
        public string proCatNombre { get; set; } = "";
    }
}
