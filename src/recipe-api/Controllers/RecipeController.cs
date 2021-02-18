using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using recipe.common;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace recipe_api.Controllers
{
    [Route("api/recipes")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        // GET: api/<RecipeController>
        [HttpGet]
        public IEnumerable<Recipe> Get()
        {
            return new[]
            {
                new Recipe {Name = "Apple Stack Cake"},
                new Recipe {Name = "Meatball Subs"}
            };
        }

        // GET api/<RecipeController>/5
        [HttpGet("{id}")]
        public Recipe Get(Guid id)
        {
            return new Recipe {RecipeId = id, Name = "Auto-gen recipe for id: " + id};
        }

        // POST api/<RecipeController>
        [HttpPost]
        public void Post([FromBody] Recipe value)
        {
        }

        // PUT api/<RecipeController>/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] Recipe value)
        {
        }

        // DELETE api/<RecipeController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
        }
    }
}
