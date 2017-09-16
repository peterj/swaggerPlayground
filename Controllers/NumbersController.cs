using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace swaggerPlayground.Controllers
{
    [Route("api/[controller]")]
    public class NumbersController : Controller
    {
        // GET api/numbers
        [HttpGet]
        public IEnumerable<int> Get()
        {
            return new int[] { 1, 2, 3 };
        }

        // GET api/numbers/5
        [HttpGet("{id}")]
        public int Get(int id)
        {
            return 1;
        }

        // POST api/numbers
        [HttpPost]
        public void Post([FromBody]int value)
        {
        }

        // PUT api/numbers/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]int value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
