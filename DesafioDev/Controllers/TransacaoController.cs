using System;
using DesafioDev.Models;
using DesafioDev.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DesafioDev.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransacaoController : ControllerBase
    {

        private readonly ICalculo _calculo;

        public TransacaoController(ICalculo calculo)
        {
            _calculo = calculo;
        }

        [HttpPost]
        public IActionResult Post(Transacao transacao)
        {
            try
            {
                var resposta = new { ValorLiquido = Math.Round(_calculo.CalculoTaxa(transacao), 2) };
                return Ok(resposta);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}