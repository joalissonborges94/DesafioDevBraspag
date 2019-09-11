using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioDev.Models.Validations
{
    public class ValidacaoTipo : ValidationAttribute
    {
        public List<string> valoresPermitidos;


        public ValidacaoTipo()
        {
            valoresPermitidos = new List<string>()
            {
                "Credito", "Debito"
            };

        }

        public override bool IsValid(object value)
        {
            string valorBandeira = (string)value;

            if (valoresPermitidos.Contains(valorBandeira))
            {
                return true;
            }

            return false;
        }
    }
}
