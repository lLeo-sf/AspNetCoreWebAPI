using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WEBAPI;

namespace WebAPI.Controllers
{   
    [ApiController]
    [Route("api/[controller]")]
    public class ProfessorController : ControllerBase
    {
        public ProfessorController(){}
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Professores: Leonardo");
        }
    }
}