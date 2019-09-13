using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioDev.Models.Validations
{
    public class ValidacaoAdquirente : ValidationAttribute
    {
        public List<string> valoresPermitidos;

        public ValidacaoAdquirente()
        {
            valoresPermitidos = new List<string>()
            {
                "a", "b", "c"
            };
        }

        public override bool IsValid(object value)
        {
            string valorAdquirente = (string)value;

            if (valorAdquirente == null)
                return false;

            if (valoresPermitidos.Contains(valorAdquirente.ToLower()))
            {
                return true;
            }

            return false;
        }


    }
}
