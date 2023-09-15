using DoctorPatient.Data;
using DoctorPatient.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DoctorPatientWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillsController : ControllerBase
    {
        SkillsRepository repository = null;
        // skillsRepository=new SkillsRepository(context)
        public SkillsController( DemoContext context)
        {
            this.repository = new SkillsRepository(context);
        }
        // GET: api/<SkillsController>
        [HttpGet]
        public IEnumerable<Skill> Get()
        {
            return repository.GetAllSkills();
            //return new string[] { "value1", "value2" };
        }

        // GET api/<SkillsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SkillsController>
        //[Route("api/Skills")]
        [HttpPost]
        public IActionResult Post([FromBody] Skill value)
        {
            repository.AddSkills(value);
            return Ok();
        }

        // PUT api/<SkillsController>/5
        [HttpPut()]
        public void Put([FromBody] Skill value)
        {
            repository.UpdateSkills(value);
        }

        // DELETE api/<SkillsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            repository.DeleteSkills(id);
        }
    }
}
