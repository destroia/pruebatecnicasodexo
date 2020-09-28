using Modelos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
namespace Data.Reposotory
{
    public class FacturacionRepo : Interfaz.IFacturacion
    {
        DataContext DB = new DataContext();
        public async Task<IEnumerable<Facturacion>> Getfacturacion(Guid idFactura)
        {
            return await DB.Facturacion.Where(x => x.IdFactura == idFactura).ToListAsync();
        }
    }
}
