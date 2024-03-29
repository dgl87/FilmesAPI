﻿using FluentResults;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using UsuariosAPI.Data.Dtos;
using UsuariosAPI.Services;

namespace UsuariosAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CadastroController : ControllerBase
    {
        private CadastroService _cadastroService;

        public CadastroController(CadastroService cadastroService)
        {
            _cadastroService = cadastroService;
        }

        [HttpPost]
        public IActionResult CadastraUsuario(CreateUsuarioDto createDto)
        {
            Result resultado = _cadastroService.CadastraUsuario(createDto);
            if (resultado.IsFailed)
            {
                return StatusCode(500);
            }
            return Ok(resultado.Successes.FirstOrDefault());
        }
    }
}