using System;
using System.Collections.Generic;
using System.Text;

namespace Modelos
{
    public class Facturacion
    {
        public Guid Id { get; set; }
        public Guid IdFactura { get; set; }
        public Guid IdProducto { get; set; }
        public int Cantidad { get; set; }
        public string NombreProducto { get; set; }
        public decimal Costo { get; set; }
        public decimal Impuesto { get; set; }
        public decimal PrecioTotal { get; set; }

    }
}
