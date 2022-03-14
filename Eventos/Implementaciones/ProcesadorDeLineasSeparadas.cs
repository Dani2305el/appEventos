using Eventos.Definiciones;
using Eventos.Modelos;
using System;
using System.Collections.Generic;

namespace Eventos.Implementaciones
{
    public class ProcesadorDeLineasSeparadas
    {
        private readonly IValidadorFormatoDeFecha validadorFormatoDeFecha;
        private readonly IValidadorLongitudNombreDeEvento validadorLongitudNombreDeEvento;
        private List<Evento> eventosGenerados;

        public ProcesadorDeLineasSeparadas(IValidadorFormatoDeFecha validadorFormatoDeFecha, 
            IValidadorLongitudNombreDeEvento validadorLongitudNombreDeEvento)
        {
            this.validadorFormatoDeFecha = validadorFormatoDeFecha;
            this.validadorLongitudNombreDeEvento = validadorLongitudNombreDeEvento;
        }
        public void procesarLineasSeparadasParaGenerarEvento(List<String[]> arrayDeLineasSeparadas)
        {
            eventosGenerados = new List<Evento>();
            foreach (String[] array in arrayDeLineasSeparadas)
            {
                validadorFormatoDeFecha.validarFormatoDeFecha(array[1]);
                validadorLongitudNombreDeEvento.validarLongitudNombreDeEvento(array[0]);
                generarEvento(array[0], array[1]);
            }
        }
        private void generarEvento(String nombre, String fecha)
        {
            Evento e = new Evento(nombre, DateTime.Parse(fecha));
            eventosGenerados.Add(e);    
        }
        public List<Evento> recuperarEventosGenerados()
        {
            return eventosGenerados;
        }
    }
}
