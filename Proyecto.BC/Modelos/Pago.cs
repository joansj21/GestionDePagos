using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.BC.Modelos
{
    public class Pago
    {
        public string pan { get; set; }
        public string fechaVencimiento { get; set; }
        public string cvv { get; set; }
        public int commercio { get; set; }
        public int terminal { get; set; }
        public decimal Total { get; set; }
    }
}
