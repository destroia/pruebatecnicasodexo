using System;
using System.Collections.Generic;
using System.Text;

namespace Modelos
{
    public class Cliente
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public virtual ICollection<Factura>  Facturas { get; set; }
    }
}
