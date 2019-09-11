using DesafioDev.Models;
using DesafioDev.Repository.Interfaces;
using System.Collections.Generic;

namespace DesafioDev.Repository
{
    public class TaxaRepositorio : ITaxaRepositorio
    {
       private List<Taxa> TaxasA = new List<Taxa>
        {
            new Taxa() { Bandeira = "Visa", Credito = 2.25, Debito = 2.00 },
            new Taxa() { Bandeira = "Master", Credito = 2.35, Debito = 1.98 }

        };

        private List<Taxa> TaxasB = new List<Taxa>
        {
            new Taxa() { Bandeira = "Visa", Credito = 2.50, Debito = 2.08 },
            new Taxa() { Bandeira = "Master", Credito = 2.65, Debito = 1.75 }

        };

        private List<Taxa> TaxasC = new List<Taxa>
        {
            new Taxa() { Bandeira = "Visa", Credito = 2.75, Debito = 2.16 },
            new Taxa() { Bandeira = "Master", Credito = 3.10, Debito = 1.58 }
        };

        public List<Taxa> GetTaxasA()
        {
            return TaxasA;
        }

        public List<Taxa> GetTaxasB()
        {
            return TaxasB;
        }

        public List<Taxa> GetTaxasC()
        {
            return TaxasC;
        }
    }
}
