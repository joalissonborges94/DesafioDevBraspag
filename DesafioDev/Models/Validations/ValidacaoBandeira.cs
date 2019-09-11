using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioDev.Models.Validations
{
    public class ValidacaoBandeira : ValidationAttribute
    {
        public List<string> valoresPermitidos;


        public ValidacaoBandeira()
        {
            valoresPermitidos = new List<string>()
            {
                "visa", "master"
            };
        }

        public override bool IsValid(object value)
        {
            string valorBandeira = (string)value;

            if (valoresPermitidos.Contains(valorBandeira.ToLower()))
            {
                return true;
            }

            return false;

        }

    }
}
