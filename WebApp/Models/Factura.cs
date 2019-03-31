using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Factura
    {
        public int IdFactura { get; set; }
        public string Descripcion { get; set; }
        public int Iva { get; set; }
        public float Precio { get; set; }
    }
}
