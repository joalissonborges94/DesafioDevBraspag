using Microsoft.AspNetCore.Mvc;

namespace DesafioDev.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "APi Funcionando!!\n\n" +
                "Consulta: GET - api/mdr\n" +
                "Transação: POST - api/transacao";
        }

    }
}