using Microsoft.AspNetCore.Mvc;
using PracticeCoreWebApi5._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PracticeCoreWebApi5._0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SingController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public SingController( ApplicationDbContext db)
        {
            _db = db;
        }

        // GET: api/<SingController>
        [HttpGet]
        public IEnumerable<SignUp> Get()
        {
            return _db.SignUp.ToList();
        }

        // GET api/<SingController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SingController>
        [HttpPost]
        public void Post([FromBody] SignUp value)
        {
            _db.SignUp.Add(value);
            _db.SaveChanges();
        }

        // PUT api/<SingController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE api/<SingController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
