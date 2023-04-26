using Domain.Service;
using Domain.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace fuctlogistica.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CargueiroController : ControllerBase
    {
        private readonly ICargueiroService _cargueiroService;

        public CargueiroController(ICargueiroService cargueiroService)
        {
            _cargueiroService = cargueiroService;
        }

        [HttpGet(Name = "GetListaCargueiro")]
        public IActionResult Get()
        {
            var listaDeCargueiros = _cargueiroService.ObterCargueiroPorId(1);

            return Ok(JsonConvert.SerializeObject(listaDeCargueiros));

        }
    }
}
