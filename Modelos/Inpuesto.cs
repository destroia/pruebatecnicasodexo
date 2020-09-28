using System;
using System.Collections.Generic;
using System.Text;

namespace Modelos
{
    public class Inpuesto
    {
        public Guid Id { get; set; }
        public string TipoImpuesto { get; set; }
        public Byte  Porcentaje { get; set; }
    }
}
