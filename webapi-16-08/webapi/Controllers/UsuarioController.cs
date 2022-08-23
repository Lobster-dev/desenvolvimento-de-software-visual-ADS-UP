using Microsoft.AspNetCore.Mvc;
using System;
using API.Models;

namespace API.Controllers
{
    [ApiController]
    [Route("api/v1/usuario")]

    public class UsuarioController : ControllerBase
    {
        // GET: /api/v1/usuario/listar
        [HttpGet]
        [Route("listar")]
        public IActionResult Listar()
        {
            Usuario usuario = new Usuario
            {
            
                Email = "teste@teste.com",
                Senha = "senha"
            };
            
            return Ok(usuario);
            
        }
        
        // GET: /api/v1/usuario/create
        [HttpPost]
        [Route("create")]
        public IActionResult Cadastrar()
        {

            
            return null;
        }
    }
}