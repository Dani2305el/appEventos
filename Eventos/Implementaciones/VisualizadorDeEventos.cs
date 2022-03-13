using Eventos.Definiciones;
using Eventos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos.Implementaciones
{
    public class VisualizadorDeEventos: IVisualizadorDeEventos
    {
        private const string MENSAJE_EVENTO_OCURIDO = "ocurrió hace";
        private const string MENSAJE_EVENTO_POR_OCURRIR = "ocurrirá dentro de";

        public void vizualizarEventos(List<Evento> eventos)
        {
            foreach (Evento evento in eventos)
            {
                String mensajeOcurrencia = obtenerMensajeOcurrencia(evento.YaOcurrio);
                Console.WriteLine("El evento "+evento.Nombre+" "+mensajeOcurrencia+" "+evento.TiempoTranscurrido);
            }
        }

        public string obtenerMensajeOcurrencia(bool yaOcurrio)
        {
            if (yaOcurrio)
            {
                return MENSAJE_EVENTO_OCURIDO;
            }
            else
            {
                return MENSAJE_EVENTO_POR_OCURRIR;
            }
        }
    }
}
