using FilmesAPI.Data.Dtos.Gerentes;
using FilmesAPI.Services;
using FluentResults;
using Microsoft.AspNetCore.Mvc;

namespace FilmesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GerenteController : ControllerBase
    {
        private GerenteService _gerenteService;
        public GerenteController(GerenteService gerenteService)
        {
            _gerenteService = gerenteService;
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaGerentePorId(int id)
        {
            ReadGerenteDto readDto = _gerenteService.RecuperaGerentePorId(id);
            if (readDto != null)
            {
                return Ok(readDto);
            }

            return NotFound();
        }

        [HttpPost]
        public IActionResult AdicionaGerente([FromBody] CreateGerenteDto gerenteDto)
        {
            ReadGerenteDto readDto = _gerenteService.AdicionaGerente(gerenteDto);

            return CreatedAtAction(nameof(RecuperaGerentePorId), new { Id = readDto.Id }, readDto);
        }

        [HttpDelete("{id}")]
        public IActionResult DeletaGerente(int id)
        {
            Result resultado = _gerenteService.DeletaGerente(id);
            if (resultado.IsFailed)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}