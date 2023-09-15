using Microsoft.AspNetCore.Mvc;
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
    public class SubcategoryController : ControllerBase
    {
        SubCategoryRepository repository = null;
        public SubcategoryController(ApplicationDbContext db)
        {
            this.repository = new SubCategoryRepository(db);
        }
        // GET: api/<SubcategoryController>
        [HttpGet]
        public IEnumerable<SubCategory> Get()
        {
            return repository.GetAllSubCategories();
        }

        // GET api/<SubcategoryController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SubcategoryController>
        [HttpPost]
        public void Post([FromBody] SubCategory value)
        {
            repository.AddSubCategory(value);
        }

        // PUT api/<SubcategoryController>/5
        [HttpPut()]
        public void Put([FromBody] SubCategory value)
        {
            repository.UpdateSubCategory(value);

        }

        // DELETE api/<SubcategoryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            repository.DeleteCategory(id);
        }
    }
}
