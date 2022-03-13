using Eventos.Definiciones;
using Eventos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos.Implementaciones
{
    public class ProcesadorOcurrenciaDeEventos: IProcesadorOcurrenciaDeEventos
    {
        private const int CANTIDAD_MAXIMA_DE_MINUTOS_PARA_CONSIDERAR_HORAS = 60;
        private const int CANTIDAD_MAXIMA_DE_HORAS_PARA_CONSIDERAR_DIAS = 24;
        private const int CANTIDAD_MAXIMA_DE_DIAS_PARA_CONSIDERAR_MESES = 31;

        public void procesarOcurrenciaDeEventos(List<Evento> eventos,DateTime fechaActual)
        {
            foreach (Evento evento in eventos)
            {
                if (evento.FechaOcurrencia > fechaActual)
                {
                    evento.YaOcurrio = false;
                }
                else
                {
                    evento.YaOcurrio = true;
                }
                evento.TiempoTranscurrido = calcularTiempoTranscurrido(evento.FechaOcurrencia, fechaActual);
            }

        }
        public String calcularTiempoTranscurrido(DateTime fechaEvento,DateTime fechaActual)
        {
            String tiempoTranscurrido = "";
            TimeSpan timeSpanDiferencia = fechaEvento - fechaActual;

            int minutos = (int)Math.Abs(timeSpanDiferencia.TotalMinutes);
            int horas = (int)Math.Abs(timeSpanDiferencia.TotalHours);
            int dias = (int)Math.Abs(timeSpanDiferencia.TotalDays);
            int meses = dias / 31;

            if (minutos < CANTIDAD_MAXIMA_DE_MINUTOS_PARA_CONSIDERAR_HORAS)
            {
                tiempoTranscurrido = minutos + " minutos";
            }
            else if (horas < CANTIDAD_MAXIMA_DE_HORAS_PARA_CONSIDERAR_DIAS && minutos >= CANTIDAD_MAXIMA_DE_MINUTOS_PARA_CONSIDERAR_HORAS)
            {
                tiempoTranscurrido = (int)horas + " horas";
            }
            else if (dias < CANTIDAD_MAXIMA_DE_DIAS_PARA_CONSIDERAR_MESES)
            {
                tiempoTranscurrido = (int)dias + " días";
            }
            else if (dias >= CANTIDAD_MAXIMA_DE_DIAS_PARA_CONSIDERAR_MESES)
            {
                tiempoTranscurrido = (int)meses + " meses";
            }
            return tiempoTranscurrido;
        }
    }
}
