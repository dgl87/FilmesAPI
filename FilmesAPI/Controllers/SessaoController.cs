using FilmesAPI.Data.Dtos.Sessoes;
using FilmesAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace FilmesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SessaoController : ControllerBase
    {
        private SessaoService _sessaoService;

        public SessaoController(SessaoService sessaoService)
        {
            _sessaoService = sessaoService;
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaSessaoPorId(int id)
        {
            ReadSessaoDto readDto = _sessaoService.RecuperaSessaoPorId(id);
            if (readDto != null)
            {
                return Ok(readDto);
            }

            return NotFound();
        }

        [HttpPost]
        public IActionResult AdicionaSessao([FromBody] CreateSessaoDto sessaoDto)
        {
            ReadSessaoDto readDto = _sessaoService.AdicionaSessao(sessaoDto);

            return CreatedAtAction(nameof(RecuperaSessaoPorId), new { Id = readDto.Id }, readDto);
        }
    }
}