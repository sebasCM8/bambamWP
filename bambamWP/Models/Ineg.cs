using System.Text.Json;
using System.Text.Json.Serialization;

namespace bambamWP.Models
{
    public class Ineg
    {
        public int ieId { get; set; } = 0;
        public int ieTipo { get; set; } = 0;
        public int iePro { get; set; } = 0;
        public decimal ieCant { get; set; } = 0;
        public DateTime ieFvto { get; set; } = DateTime.Now;
        public decimal iePrecio { get; set; } = 0;
        public int ieEstado { get; set; } = 0;

        [JsonIgnore]
        public string ieProdResume { get; set; } = "";
        [JsonIgnore]
        public string iePreciostr { get; set; } = "";
        [JsonIgnore]
        public string ieCantidadstr { get; set; } = "";
        [JsonIgnore]
        public String ieFvtostr { get; set; } = "";
    }
}
