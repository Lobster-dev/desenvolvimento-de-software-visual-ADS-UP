using Microsoft.AspNetCore.Mvc;
using System;
using API.Models;
using System.Collections.Generic;
using System.Linq;

namespace API.Controllers
{

    

    [ApiController]
    [Route("api/v1/usuario")]

    public class UsuarioController : ControllerBase
    {

        private static List<Usuario> usuarios = new List<Usuario>();

        // GET: /api/v1/usuario/listar
        [HttpGet]
        [Route("listar")]
        public IActionResult Listar()
        {            
            return Ok(usuarios); // 200
            
        }
        
        // POST: /api/v1/usuario/create
        [HttpPost]
        [Route("create")]
        public IActionResult Cadastrar([FromBody]Usuario usuario) //[FromRoute]string email,[FromRoute]string senha
        {
            // Usuario usuario = new Usuario
            // {
            //     Email = email,
            //     Senha = senha
            // };
            
            usuarios.Add(usuario);

            return Created("", usuario); //201  
        }

        // GET: /api/v1/usuario/find/email
        [HttpGet]
        [Route("find/{email}")]
        public IActionResult find([FromRoute]String email) //[FromRoute]string email,[FromRoute]string senha
        {
            // foreach (var usuario_lista in usuarios)
            // {
            //     if (usuario_lista.Email.Equals(email))
            //     {
            //         return Ok(usuario_lista); //200    
            //     }
            // }
            // return NotFound(); //404
            Usuario usuario = usuarios.FirstOrDefault
            (
                u => u.Email.Equals(email)
            );
            if (usuario == null)
            {
                return NotFound(); //404    
            }
            return Ok(usuario); //200            
        }
    }
}