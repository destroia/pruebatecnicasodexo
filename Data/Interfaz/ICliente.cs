using System;
using System.Collections.Generic;
using System.Text;
using Modelos;

namespace Data.Interfaz
{
    public interface ICliente
    {
        System.Threading.Tasks.Task<IEnumerable<Cliente>> GetClientes();
    }
}
