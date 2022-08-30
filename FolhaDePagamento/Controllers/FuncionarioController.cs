using Microsoft.AspNetCore.Mvc;
using System;
using API.Models;
using System.Collections.Generic;
using System.Linq;

namespace API.Controllers
{

    

    [ApiController]
    [Route("api/v1/employee")]

    public class FuncionarioController : ControllerBase
    {

        private static List<Funcionario> funcionarios = new List<Funcionario>();

        // GET: /api/v1/Employe/listar
        [HttpGet]
        [Route("listar")]
        public IActionResult Listar()
        {            
            return Ok(funcionarios); // 200
            
        }
        
        // POST: /api/v1/Employe/create
        [HttpPost]
        [Route("create")]
        public IActionResult Cadastrar([FromBody]Funcionario funcionario)
        {           
            funcionarios.Add(funcionario);

            return Created("", funcionario); //201  
        }

        // GET: /api/v1/Employe/find/cpf
        [HttpGet]
        [Route("find/{cpf}")]
        public IActionResult find([FromRoute]String cpf)
        {
            Funcionario funcionario = funcionarios.FirstOrDefault(f => f.Cpf.Equals(cpf));
            return funcionario != null ? Ok(funcionario) : NotFound();



        }

        // DELETE: /api/v1/Employe/delete/cpf
        [HttpDelete]
        [Route("delete/{cpf}")]
        public IActionResult delete([FromRoute]String cpf)
        {
            Funcionario funcionarioLista = funcionarios.FirstOrDefault(
                f => f.Cpf.Equals(cpf)
            );

            if (funcionarioLista != null)
            {
                funcionarios.Remove(funcionarioLista);
                return Ok(funcionarioLista);
            }
            return NotFound();
        }


        // PATCH: /api/v1/Employe/change/
        [HttpPatch]
        [Route("change/")]
        public IActionResult changeEmployee([FromBody]Funcionario funcionario)
        {
            Funcionario funcionarioEncontrado = funcionarios.FirstOrDefault(
                f => f.Cpf.Equals(funcionario.Cpf)
            );

            if (funcionarioEncontrado != null)
            {
                // Alteração do objeto

                funcionarioEncontrado.Nome = funcionario.Nome;
                funcionarioEncontrado.Cpf = funcionario.Cpf;
                funcionarioEncontrado.DataDeNascimento = funcionario.DataDeNascimento;
                funcionarioEncontrado.CreatedAt = funcionario.CreatedAt;

                return Ok(funcionarioEncontrado);
            }
            return NotFound();
        }


    }
}