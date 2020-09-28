using System;
using System.Collections.Generic;
using System.Text;
using Modelos;
namespace Data.Interfaz
{
    public interface IProducto
    {
        IEnumerable<Producto> GetProductos(Guid IdFactura);
    }
}
