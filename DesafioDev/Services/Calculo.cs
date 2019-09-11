using DesafioDev.Models;
using DesafioDev.Repository.Interfaces;
using DesafioDev.Services.Interfaces;
using System;
using System.Linq;

namespace DesafioDev.Services
{
    public class Calculo : ICalculo
    {
        private readonly IMdrRepositorio _mdrRepositorio;

        public Calculo(IMdrRepositorio mdrRepositorio)
        {
            _mdrRepositorio = mdrRepositorio;
        }

        public double CalculoTaxa(Transacao _transacao)
        {
                MDR Mdr = _mdrRepositorio.GetMDR().FirstOrDefault(mdr => mdr.Adquirente == _transacao.Adquirente);

                Taxa taxa = Mdr.Taxas.FirstOrDefault(_taxa => _taxa.Bandeira == _transacao.Bandeira);

                if (_transacao.Tipo == "Credito")
                    return CalculoTaxacredito(_transacao, taxa);

                if (_transacao.Tipo == "Debito")
                    return CalculoTaxadebito(_transacao, taxa);

                return 0;           
        }

        private double CalculoTaxacredito(Transacao _transacao, Taxa taxa)
        {
            return _transacao.Valor - (_transacao.Valor * taxa.Credito / 100);
        }

        private double CalculoTaxadebito(Transacao _transacao, Taxa taxa)
        {
            {
                return _transacao.Valor - (_transacao.Valor * taxa.Debito / 100);
            }
        }
    }
}
