using AutoMapper;
using FilmesAPI.Data;
using FilmesAPI.Data.Dtos.Cinemas;
using FilmesAPI.Models;
using FilmesAPI.Services;
using FluentResults;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace FilmesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CinemaController : ControllerBase
    {
        private CinemaService _cinemaService;
        public CinemaController(CinemaService cinemaService)
        {
            _cinemaService = cinemaService;
        }

        [HttpGet]
        public IActionResult RecuperaCinema([FromQuery] string nomeDoFilme)
        {
            List<ReadCinemaDto> readDto = _cinemaService.RecuperaCinema(nomeDoFilme);
            if (readDto != null)
            {
                return Ok(readDto);
            }

            return NotFound();            
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaCinemaPorId(int id)
        {
            ReadCinemaDto readDto = _cinemaService.RecuperaCinemaPorId(id);
            if (readDto != null)
            {
                return Ok(readDto);
            }

            return NotFound();            
        }

        [HttpPost]
        public IActionResult AdicionaCinema([FromBody] CreateCinemaDto cinemaDto)
        {
            ReadCinemaDto readDto = _cinemaService.AdicionaCinema(cinemaDto);            

            return CreatedAtAction(nameof(RecuperaCinemaPorId), new { Id = readDto.Id }, readDto);
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaCinema(int id, [FromBody] UpdateCinemaDto cinemaDto)
        {
            Result resultado = _cinemaService.AtualizaCinema(id, cinemaDto);
            if (resultado.IsFailed)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCinema(int id)
        {
            Result resultado = _cinemaService.DeletaCinema(id);
            if (resultado.IsFailed)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}