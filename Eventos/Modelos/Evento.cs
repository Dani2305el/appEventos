using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos.Modelos
{
    public class Evento
    {
        private String nombre;
        private DateTime fechaOcurrencia;
        private bool yaOcurrio;
        private string tiempoTranscurrido;

        public Evento(string nombre, DateTime fechaOcurrencia)
        {
            this.Nombre = nombre;
            this.FechaOcurrencia = fechaOcurrencia;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime FechaOcurrencia { get => fechaOcurrencia; set => fechaOcurrencia = value; }
        public bool YaOcurrio { get => yaOcurrio; set => yaOcurrio = value; }
        public string TiempoTranscurrido { get => tiempoTranscurrido; set => tiempoTranscurrido = value; }
    }
}
