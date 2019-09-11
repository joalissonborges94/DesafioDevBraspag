using DesafioDev.Models.Validations;
using System.ComponentModel.DataAnnotations;

namespace DesafioDev.Models
{
    public class Transacao
    {
        [MaxLength(1)]
        [ValidacaoAdquirente(ErrorMessage = "Adquirente Inválida. Valores aceitos: A, B, C")]
        [Required(AllowEmptyStrings = false)]
        public string Adquirente { get; set; }

        [ValidacaoBandeira(ErrorMessage = "Bandeira inválida. Valores aceitos: Visa, Master")]
        [Required(AllowEmptyStrings = false)]
        public string Bandeira { get; set; }
        [ValidacaoTipo(ErrorMessage = "Tipo inválido. Valores aceitos: Credito, Debito")]
        [Required(AllowEmptyStrings = false)]
        public string Tipo { get; set; }

        [Required(AllowEmptyStrings = false)]
        public double Valor { get; set; }
    }
}
