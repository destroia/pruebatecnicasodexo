using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelos
{
    public class Producto
    {
        [Key, Required]
        public Guid Id { get; set; }
        [ForeignKey("Inpuesto"), Required]
        public Guid Inpuesto { get; set; }
        [Required]
        public string NombreProducto { get; set; }
        [Required]
        public string DescripcionProducto { get; set; }
        [Required]
        public decimal Precio { get; set; }
        [Required]
        public decimal Iva { get; set; }
        [Required]
        public decimal PrecioIva { get; set; }
       

    }
}
