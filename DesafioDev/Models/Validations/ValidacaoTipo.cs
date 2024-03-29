﻿using System;
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
                "credito", "debito"
            };

        }

        public override bool IsValid(object value)
        {
            string valorTipo = (string)value;

            if (valorTipo == null)
                return false;

            if (valoresPermitidos.Contains(valorTipo.ToLower()))
            {
                return true;
            }

            return false;
        }
    }
}
