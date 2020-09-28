using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Interfaz
{
    public interface IFacturacion
    {
        System.Threading.Tasks.Task<IEnumerable<Modelos.Facturacion>> Getfacturacion(Guid idFactura);
            
    }
}
