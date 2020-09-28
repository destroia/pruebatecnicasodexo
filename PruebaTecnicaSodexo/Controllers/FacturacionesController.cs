using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PruebaTecnicaSodexo.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class FacturacionesController : ControllerBase
    {
        Data.Reposotory.FacturacionRepo Repo = new Data.Reposotory.FacturacionRepo();
     
    

        // GET api/<FacturacionesController>/5
        [HttpGet("{id}")]
        public async Task<IEnumerable<Modelos.Facturacion>>  GetFacturaciones(Guid id)
        {
            return await Repo.Getfacturacion(id);
        }

        // POST api/<FacturacionesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<FacturacionesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<FacturacionesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
