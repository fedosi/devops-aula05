using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using conversaotemperatura.estrutura;
using conversaotemperatura.imp;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace conversaotemperatura.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class conversao : ControllerBase
    {
        // GET: api/<conversao>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<conversao>/5
        [HttpGet("{id}")]
        public sconversor Get(string unidadeorigem, string valororigem, string unidadedestino)
        {
            sconversor ent = new sconversor(unidadeorigem, valororigem, unidadedestino);
            return conversor.executar(ent);
        }

        // POST api/<conversao>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<conversao>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<conversao>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
