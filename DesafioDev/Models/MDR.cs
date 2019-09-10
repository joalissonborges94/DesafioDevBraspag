using System.Collections.Generic;

namespace DesafioDev.Models
{
    public class MDR
    {
        public string Adquirente { get; set; }
        public IList<Taxa> Taxas { get; set; }
    }
}
