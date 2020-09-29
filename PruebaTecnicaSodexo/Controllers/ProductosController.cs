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
    public class ProductosController : ControllerBase
    {
        ProductoRepo Repo = new ProductoRepo();
        // GET: api/<ProductosController>
        [HttpGet]
        public async Task<IEnumerable<Modelos.Producto>> GetPeoductos()
        {
            return await Repo.GetProductos();
        }

        // GET api/<ProductosController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProductosController>
        [HttpPost("{id}")]
        public async Task<bool> PostVenta(List<Modelos.Producto> lp,Guid id)
        {
            return await Repo.Venta(lp,id);
        }

        // PUT api/<ProductosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
