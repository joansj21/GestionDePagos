using Proyecto.BC.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.BC.LogicaDeNegocios
{
    public class GeneratePagoAdquiriencia
    {
        public static PagoAdquiriencia Generate(Pago pago) {

            return new PagoAdquiriencia() { 
            Amount=pago.Total,
            Cvv=pago.cvv,
            ExpiryDate=pago.fechaVencimiento,
            IdentifyCommerce=pago.commercio.ToString(),
            IdentifyTerminal=pago.terminal.ToString(),
            Pan=pago.pan,
            };
        }

    }
}
