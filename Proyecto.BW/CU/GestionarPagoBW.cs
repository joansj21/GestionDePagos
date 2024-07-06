using Proyecto.BC.LogicaDeNegocios;
using Proyecto.BC.Modelos;
using Proyecto.BW.Interfaces.BW;
using Proyecto.BW.Interfaces.SG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.BW.CU
{
    public class GestionarPagoBW : IGestionarPagoBW
    {
        private readonly IGestionarPagoDA gestionarPagoDA;
        private readonly IGestionarPagoSG gestionarPagoSG;
        public GestionarPagoBW(IGestionarPagoDA estionarPagoDA, IGestionarPagoSG gestionarPagoSG)
        {
            this.gestionarPagoDA = estionarPagoDA;
            this.gestionarPagoSG = gestionarPagoSG;
        }
        public async Task<bool> resgistrePago(Pago pago)
        {
            var resultSG = await gestionarPagoSG.resgistrePago(GeneratePagoAdquiriencia.Generate(pago));

            if (!resultSG) return false;
            
            return await gestionarPagoDA.resgistrePago(pago);
        }
    }
}
