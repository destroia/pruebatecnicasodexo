using System;
using System.Collections.Generic;
using System.Text;
using Modelos;
namespace Data.Interfaz
{
    public interface IFactura
    {
        System.Threading.Tasks.Task<IEnumerable<Factura>> GetFacturas(Guid IdCliente);

    }
}
