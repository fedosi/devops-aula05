using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using conversaotemperatura.modelo;
using conversaotemperatura.negocio.servicos;
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
        public object Get()
        {
            return servicoconversor.conversores();
        }

        // GET api/<conversao>/5
        [HttpGet("{tipoconversao}/{valororigem}")]
        public sconversorRetorno Get(string tipoconversao, string valororigem)
        {
            return servicoconversor.executar(tipoconversao, valororigem);
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
