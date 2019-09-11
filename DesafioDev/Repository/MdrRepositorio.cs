using DesafioDev.Models;
using DesafioDev.Repository.Interfaces;
using System.Collections.Generic;

namespace DesafioDev.Repository
{
    public class MdrRepositorio : IMdrRepositorio
    {
        private List<MDR> ListaMdr;
        private readonly ITaxaRepositorio _taxarepositorio;

        public MdrRepositorio(ITaxaRepositorio taxarepositorio)
        {
            _taxarepositorio = taxarepositorio;
        }

        public List<MDR> GetMDR()
        {
            return ListaMdr = new List<MDR>()
            {
               new MDR()
               {
                   Adquirente = "A",
                   Taxas = _taxarepositorio.GetTaxasA()

               },

               new MDR()
               {
                   Adquirente = "B",
                   Taxas = _taxarepositorio.GetTaxasB()
               },
               new MDR()
               {
                      Adquirente = "C",
                      Taxas = _taxarepositorio.GetTaxasC()
               },
            };

        }


    }
}
