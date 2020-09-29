using System;
using System.Collections.Generic;
using System.Text;
using Modelos;
namespace Data.Interfaz
{
    public interface IProducto
    {

        System.Threading.Tasks.Task<IEnumerable<Producto>> GetProductos();
        System.Threading.Tasks.Task<bool> Venta(List<Producto> lp ,Guid idCli);
    }
}
