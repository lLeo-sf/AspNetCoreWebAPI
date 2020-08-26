using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WEBAPI;
using System.Linq;

namespace WebAPI.Controllers
{   
    [ApiController]
    [Route("api/[controller]")]
    public class alunoController : ControllerBase
    {
        public List<Aluno> Alunos = new List<Aluno> () {
            new Aluno(){
                Id = 1,
                Nome = "Leonardo",
                Sobrenome = "Fernandes",
                Telefone = "984282859"
            },
            new Aluno(){
                Id = 2,
                Nome = "Leonardo1",
                Sobrenome = "Fernandes",
                Telefone = "984282859"
            },new Aluno(){
                Id = 3,
                Nome = "Leonardo2   ",
                Sobrenome = "Fernandes",
                Telefone = "984282859"
            },
        };

        public alunoController(){}

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Alunos);
        }

        [HttpGet("byId/{id}")] // [HtppGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var aluno = Alunos.FirstOrDefault(a => a.Id == id);

            if(aluno == null) return BadRequest("Id não encontrada");

           return Ok(aluno);
        }

        [HttpGet("byName/{nome}/{sobrenome}")]
        public IActionResult GetByName(string nome, string sobrenome)
        {
            var aluno = Alunos.FirstOrDefault(a => 
                a.Nome.Contains(nome) && a.Sobrenome.Contains(sobrenome)
                );

            if(aluno == null) return BadRequest("Nome não encontrado");

           return Ok(aluno);
        }

        [HttpPost]
        public IActionResult Post(Aluno aluno)
        {
           return Ok(aluno);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Aluno aluno)
        {
           return Ok(aluno);
        }
        
        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Aluno aluno)
        {
           return Ok(aluno);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
           return Ok("Deletado");
        }
    }   
}