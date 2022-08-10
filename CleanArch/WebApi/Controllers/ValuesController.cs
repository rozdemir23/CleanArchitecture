using WebApi.Models;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        List<Urun> uruns = new List<Urun>()
        {
            new Urun(1, "Tisort", "Ust Giyim", DateTime.Today),
            new Urun(2, "Atkı", "Aksesuar", DateTime.Today),
            new Urun(3, "Pantalon", "Alt Giyim", DateTime.Today),
            new Urun(4, "Mont", "Dis Giyim", DateTime.Today)

        };

        // GET: api/<ValuesController>
        [HttpGet]
        public List<Urun> Get()
        {
            return uruns;
        }


        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>       
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }


        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
            public void Put(int id, [FromBody] string value)
            {
            }

            // DELETE api/<ValuesController>/5
            [HttpDelete("{id}")]
            public void Delete(int id)
            {
            }

        }
}


