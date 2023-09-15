using Microsoft.AspNetCore.Mvc;
using MIVI.Data;
using MIVI.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MIVIWebAPIEcommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CategoryController : ControllerBase
    {
        CategoryRepository repository = null;
        public CategoryController( ApplicationDbContext context)
        {
            this.repository = new CategoryRepository(context);
        }
        // GET: api/<CategoryController>
        [HttpGet]
        public IEnumerable<Category> Get()
        {
            return repository.GetAllCategory();
        }

        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CategoryController>
        [HttpPost]
        public IActionResult Post([FromBody] Category value)
        {
            repository.AddCategory(value);
            return Ok();
        }

        // PUT api/<CategoryController>/5
        [HttpPut()]
        public void Put([FromBody] Category value)
        {
            repository.UpdateCategory(value);

        }

        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            repository.DeleteCategory(id);
        }
    }
}
