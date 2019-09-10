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
            try
            {
                MDR Mdr = _mdrRepositorio.GetMDR().FirstOrDefault(mdr => mdr.Adquirente == _transacao.Adquirente);

                Taxa taxa = Mdr.Taxas.FirstOrDefault(_taxa => _taxa.Bandeira == _transacao.Bandeira);

                if (_transacao.Tipo == "Credito")
                    return CalculoTaxaCredito(_transacao, taxa);

                if (_transacao.Tipo == "Debito")
                    return CalculoTaxaDebito(_transacao, taxa);

                return 0;
            }
            catch
            {
                throw new Exception("Dados inseridos inválidos. Confira abaixo os dados aceitos pela APi:\n\n" +
                    "Adquirente: A, B e C\n" +
                    "Bandeira: Visa e Master\n" +
                    "Tipo: Debito e Credito\n\n" +
                    "Tente novamente utilizando os dados acima.");
            }
        }

        private double CalculoTaxaCredito(Transacao _transacao, Taxa taxa)
        {
            return _transacao.Valor - (_transacao.Valor * taxa.Credito / 100);
        }

        private double CalculoTaxaDebito(Transacao _transacao, Taxa taxa)
        {
            {
                return _transacao.Valor - (_transacao.Valor * taxa.Debito / 100);
            }
        }
    }
}
