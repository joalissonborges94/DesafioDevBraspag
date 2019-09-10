using DesafioDev.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DesafioDev.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class MdrController : ControllerBase
    {

        public readonly IMdrRepositorio _mdrRepositorio;

        public MdrController(IMdrRepositorio mdrRepository)
        {
            _mdrRepositorio = mdrRepository;
        }

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_mdrRepositorio.GetMDR());
        }

    }
}