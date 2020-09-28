using Modelos;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
namespace Data.Reposotory
{
    public class ClienteRepo : Interfaz.ICliente
    {
        DataContext DB = new DataContext();
        public async Task<IEnumerable<Cliente>> GetClientes()
        {
            return await DB.Clientes.ToListAsync();
            
        }
    }
}
