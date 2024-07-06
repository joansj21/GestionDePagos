using Proyecto.BC.Constantes;
using Proyecto.BC.Modelos;
using Proyecto.BW.Interfaces.SG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Proyecto.SG
{
    public class GestionarPagoSG : IGestionarPagoSG
    {

        private readonly HttpClient clienteHttp;

        public GestionarPagoSG(HttpClient clienteHttp)
        {
            this.clienteHttp = clienteHttp;
        }
        public async Task<bool> resgistrePago(PagoAdquiriencia pago)
        {
            // Serializar el objeto user a JSON
            var jsonContent = new StringContent(JsonSerializer.Serialize(pago), System.Text.Encoding.UTF8, "application/json");

            HttpResponseMessage respuesta = await clienteHttp.PostAsync(URLGateWayAdquirieneciaConstante.URL, jsonContent);

            if (!respuesta.IsSuccessStatusCode)
                throw new HttpRequestException($"Error en {URLGateWayAdquirieneciaConstante.URL} al obtener el mensaje");

            string contenido = await respuesta.Content.ReadAsStringAsync();

            // Imprimir el contenido de la respuesta
            Console.WriteLine("Contenido de la respuesta:");
            Console.WriteLine(contenido);

            // Deserializar la respuesta a un booleano
            // bool resultado = JsonSerializer.Deserialize<bool>(contenido);

            return true;
        }
    }
}
