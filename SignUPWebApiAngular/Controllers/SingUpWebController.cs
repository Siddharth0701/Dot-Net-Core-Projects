using Microsoft.AspNetCore.Mvc;
using SignUpUser.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SignUPWebApiAngular.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SingUpWebController : ControllerBase
    {
        SignUpWebFormRepository repository = null;
        public SingUpWebController(ApplicationDbContext db)
        {
            this.repository = new SignUpWebFormRepository(db);
        }
        // GET: api/<SingUpWebController>
        [HttpGet]
        public IEnumerable<SignUpWebForm> Get()
        {
            return repository.GetAllSingupUser();  ;
        }

        // GET api/<SingUpWebController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SingUpWebController>
        [HttpPost]
        public void Post([FromBody] SignUpWebForm value)
        {
            repository.AddUser(value);
        }

        // PUT api/<SingUpWebController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SingUpWebController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
