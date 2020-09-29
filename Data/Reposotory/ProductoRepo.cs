using Modelos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
namespace Data.Reposotory
{
    public class ProductoRepo : Interfaz.IProducto
    {
        DataContext DB = new DataContext();
        public async Task<IEnumerable<Producto>> GetProductos()
        {
            var LP = await DB.Productos.ToListAsync();
            var LI = await DB.inpuestos.ToListAsync();
            foreach (var item in LP)
            {
                item.PrecioTotal =  item.PrecioSinIva + ((item.PrecioSinIva * LI.Where(x => x.Id == item.Inpuesto).Select(x => x.Porcentaje).FirstOrDefault())/100);
            }
            return LP;
        }

        public async Task<bool> Venta(List<Producto> lp,Guid idCli)
        {
            try
            {
                var factura = new Factura() { Id = Guid.NewGuid(), FechaFactura = DateTime.Now, IdCliente = idCli };
                await DB.Facturas.AddAsync(factura);
                var LFacturacion = new List<Facturacion>();
                foreach (var item in lp)
                {
                    var fac = new Facturacion();
                    fac.Id = Guid.NewGuid();
                    fac.IdFactura = factura.Id;
                    fac.Cantidad = item.Cantidad;
                    fac.IdProducto = item.Id;
                    fac.NombreProducto = item.NombreProducto;
                    fac.Costo = item.PrecioSinIva;
                    fac.Impuesto = item.PrecioTotal - item.PrecioSinIva;
                    fac.PrecioTotal = item.PrecioTotal;

                    LFacturacion.Add(fac);
                }
                
                await DB.Facturacion.AddRangeAsync(LFacturacion);
                await DB.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
