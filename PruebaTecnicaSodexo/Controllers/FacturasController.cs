using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Data.Reposotory;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PruebaTecnicaSodexo.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class FacturasController : ControllerBase
    {
        FacturaRepo Repo = new FacturaRepo();
        // GET: api/<FacturasController>
        [HttpGet("{id}")]
        public async Task<IEnumerable<Modelos.Factura>> GetFacturas(Guid id)
        {
            return await Repo.GetFacturas(id);
        }

        // GET api/<FacturasController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<FacturasController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<FacturasController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<FacturasController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
