using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Factura
    {
        [Key, Required]
        public Guid Id { get; set; }
        public Guid ProductoId {get; set;}
        public DateTime FechaFactura { get; set; }

        public virtual List<Producto> productos ;
    }
}
