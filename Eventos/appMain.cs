using Eventos.Definiciones;
using Eventos.Implementaciones;
using Eventos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos
{
    public class appMain
    {
        private readonly DateTime fechaActual;
        private readonly Archivo archivo;
        private readonly ILectorDeArchivo lectorDeArchivo;
        private readonly ISeparadorDeLineasExtraidas separadorDeLineasExtraidas;
        private readonly IValidadorFormatoDeFecha validadorFormatoDeFecha;
        private readonly IValidadorLongitudNombreDeEvento validadorLongitudNombreDeEvento;
        private readonly ProcesadorDeLineasSeparadas procesadorDeLineasSeparadas;
        private readonly IProcesadorOcurrenciaDeEventos procesadorOcurrenciaDeEventos;
        private readonly IVisualizadorDeEventos visualizadorDeEventos;

        public appMain(Archivo archivo,ILectorDeArchivo lectorDeArchivo, ISeparadorDeLineasExtraidas separadorDeLineasExtraidas, 
            IValidadorFormatoDeFecha validadorFormatoDeFecha, IValidadorLongitudNombreDeEvento validadorLongitudNombreDeEvento, 
           IProcesadorOcurrenciaDeEventos procesadorOcurrenciaDeEventos, 
            IVisualizadorDeEventos visualizadorDeEventos)
        {
            this.archivo = archivo;
            this.lectorDeArchivo = lectorDeArchivo;
            this.separadorDeLineasExtraidas = separadorDeLineasExtraidas;
            this.validadorFormatoDeFecha = validadorFormatoDeFecha;
            this.validadorLongitudNombreDeEvento = validadorLongitudNombreDeEvento;
            this.procesadorDeLineasSeparadas = new ProcesadorDeLineasSeparadas(validadorFormatoDeFecha, validadorLongitudNombreDeEvento);
            this.procesadorOcurrenciaDeEventos = procesadorOcurrenciaDeEventos;
            this.visualizadorDeEventos = visualizadorDeEventos;
            fechaActual = DateTime.Now;
        }

        public void Iniciar()
        {
            lectorDeArchivo.comprobarExistenciaDelArchivo(archivo);
           
            List<String> arrayLineasLeidas = lectorDeArchivo.extraerLineas(archivo);
            
            List<String[]> arrayEventoFecha =  separadorDeLineasExtraidas.obtenerArrayEventoFecha(arrayLineasLeidas);
            procesadorDeLineasSeparadas.procesarLineasSeparadasParaGenerarEvento(arrayEventoFecha);
            List<Evento> eventosGenerados = procesadorDeLineasSeparadas.recuperarEventosGenerados();
            procesadorOcurrenciaDeEventos.procesarOcurrenciaDeEventos(eventosGenerados, fechaActual);
            visualizadorDeEventos.vizualizarEventos(eventosGenerados);
            Console.Read();

        }
    }
}
