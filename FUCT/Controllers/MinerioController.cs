using Domain.Dto;
using Domain.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace fuctlogistica.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MinerioController : ControllerBase
    {
        private readonly IMinerioService _minerioService;

        public MinerioController(IMinerioService minerioService)
        {
            _minerioService = minerioService;
        }

        [HttpGet(Name = "GetListaMinerio")]
        public IActionResult  Get()
        {
            var listaDeMinerios = _minerioService.ObterTodos();

            return Ok(JsonConvert.SerializeObject(listaDeMinerios));

        }
    }
}
