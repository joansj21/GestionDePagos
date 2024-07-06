using Proyecto.BC.Modelos;
using Proyecto.BW.Interfaces.SG;
using Proyecto.DA.Contexto;
using Proyecto.DA.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.DA.Acciones
{
    public class GestionarPagoDa : IGestionarPagoDA
    {

        private readonly GestionPagoContext _context;

        public GestionarPagoDa(GestionPagoContext context)
        {
            _context = context;
        }

        public async Task<bool> resgistrePago(Pago pago)
        {
            try
            {
                PagoDA pagoDA = new PagoDA()
                {
                    commercio = pago.commercio,
                    cvv = pago.cvv,
                    fechaVencimiento = pago.fechaVencimiento,
                    id = 0,
                    pan = pago.pan,
                    terminal = pago.terminal,
                    Total = pago.Total

                };

                await _context.AddAsync(pagoDA);

                await _context.SaveChangesAsync();

                return true;

            }catch (Exception ex)
            {

                return false;
            }


        }
    }
}
