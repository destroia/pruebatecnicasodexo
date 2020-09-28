using Modelos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
namespace Data.Reposotory
{
    public class FacturaRepo : Interfaz.IFactura
    {
        DataContext DB = new DataContext();
        public async  Task<IEnumerable<Factura>> GetFacturas(Guid IdCliente)
        {
            return await DB.Facturas.Where(x => x.IdCliente == IdCliente).ToListAsync();
        }
    }
}
