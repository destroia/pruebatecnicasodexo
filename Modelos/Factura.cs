using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelos
{
    public class Factura
    {
        [Key, Required]
        public Guid Id { get; set; }
        [Required]
        public Guid IdCliente { get; set; }
       
        [Required]
        public DateTime FechaFactura { get; set; }

       
    }
}
