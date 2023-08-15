using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmartSchool.WebAPI.Models;

namespace SmartSchool.WebAPI.Controllers
{   
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        public List<Aluno> Alunos = new List<Aluno>() {
            new Aluno()
            {
                Id = 1,
                Nome = "Marcos",
                Sobrenome = "Almeida",
                Telefone = "123456"
             },

            new Aluno()
            {
                Id = 1,
                Nome = "Marta",
                Sobrenome = "Kent",
                Telefone = "58749922"
             },

            new Aluno()
            {
                Id = 1,
                Nome = "Laura",
                Sobrenome = "Maria", 
                Telefone = "98766411"
             },

            };
        

        public AlunoController (){}

        [HttpGet]
        public IActionResult Get()
        {
           return Ok(Alunos);
           
        }
        // api/aluno/id 
        [HttpGet("{id}")]

        public IActionResult GetbyId (int id) 
        {
            var aluno = Alunos.FirstOrDefault(a => a.Id == id);
            if (aluno == null) return BadRequest ();
            return Ok(aluno);

        }

  //GET -  api/aluno/nome 
        [HttpGet("ByName")]

        public IActionResult GetbyName (string nome, string Sobrenome) 
        {
            var aluno = Alunos.FirstOrDefault(a => a.Nome.Contains(nome) && a.Sobrenome.Contains (Sobrenome));
            if (aluno == null) return BadRequest ("O aluno não foi encontrado");
            return Ok(aluno);

        }

 // POST
        [HttpPost]

        public IActionResult Post (Aluno aluno ) 
        {
             return Ok(aluno);

        }

  // PUT
        [HttpPut("{id}")]

        public IActionResult Put (int id, Aluno aluno ) 
        {
             return Ok(aluno);

        }


  // Patch
        [HttpPatch("{id}")]

        public IActionResult Patch (int id, Aluno aluno ) 
        {
             return Ok(aluno);

        }

   // DELETE
        [HttpDelete("{id}")]

        public IActionResult Delete (int id ) 
        {
             return Ok();

        }

    }
}