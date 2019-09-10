using DesafioDev.Models;
using System.Collections.Generic;

namespace DesafioDev.Repository.Interfaces
{
    public interface ITaxaRepositorio
    {
        List<Taxa> GetTaxasA();
        List<Taxa> GetTaxasB();
        List<Taxa> GetTaxasC();
    }
}
