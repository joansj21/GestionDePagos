using Proyecto.api.DTOs;
using Proyecto.BC.Modelos;

namespace Proyecto.api.Utilitarios
{
    public class MapperPago
    {

        public static Pago MapperAPago(PagoDTO pagoDTO) {


            return new Pago() { 
            commercio = pagoDTO.commercio,
            cvv=pagoDTO.cvv,
            fechaVencimiento=pagoDTO.fechaVencimiento,
            pan = pagoDTO.pan,
            terminal = pagoDTO.terminal,
            Total = pagoDTO.Total

            
            };
        }


    }
}
