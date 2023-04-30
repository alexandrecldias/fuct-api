using Domain.Dto;
using Domain.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace fuctlogistica.API.Controllers
{
    public class TransporteController : ControllerBase
    {
        private readonly ITransporteService _transporteService;

        public TransporteController(ITransporteService transporteService)
        {
            this._transporteService = transporteService;
        }

        [HttpPost]
        [Route("api/adicionarTransporte")]
        public IActionResult AdicionarProduto([FromBody] FiltroTransporteDto filtroTransporteDto)
        {
            if (filtroTransporteDto == null)
            {
                return BadRequest("Dados do produto inválidos.");
            }

            _transporteService.adicionarNovoTransporte(filtroTransporteDto);

            return Ok();
        }

    }
}
