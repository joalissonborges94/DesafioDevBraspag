using System.ComponentModel.DataAnnotations;

namespace DesafioDev.Models
{
    public class Transacao
    {
        [MaxLength(1)]
        [Required(AllowEmptyStrings = false)]
        public string Adquirente { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Bandeira { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Tipo { get; set; }

        [Required(AllowEmptyStrings = false)]
        public double Valor { get; set; }
    }
}
