namespace bambamWP.Models
{
    public class Usuario
    {
        public string usuId { get; set; } = "";
        public string usuPass { get; set; } = "";
        public string usuNombre { get; set; } = "";
        public string usuApellido { get; set; } = "";
        public string usuCI { get; set; } = "";
        public string usuCelular { get; set; } = "";
        public int usuEstado { get; set; } = 0;
    }
}
