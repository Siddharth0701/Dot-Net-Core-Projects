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
    public class LoginFormController : ControllerBase
    {
        LoginFormRepository repository =null;
        public LoginFormController( ApplicationDbContext db)
        {
            this.repository = new LoginFormRepository(db);
        }
        
        // GET: api/<LoginFormController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<LoginFormController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<LoginFormController>
        [HttpPost]
        public void Post([FromBody] LoginForm value)
        {
            repository.LoginUser(value);

        }

        // PUT api/<LoginFormController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LoginFormController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
