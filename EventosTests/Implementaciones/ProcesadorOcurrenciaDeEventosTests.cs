using Microsoft.VisualStudio.TestTools.UnitTesting;
using Eventos.Implementaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eventos.Modelos;

namespace Eventos.Implementaciones.Tests
{
    [TestClass()]
    public class ProcesadorOcurrenciaDeEventosTests
    {
        [TestMethod()]
        public void procesarOcurrenciaDeEventosTest()
        {
            // Arrange
            List<Evento> excpectedEventos = new List<Evento>() { new Evento("Evento1", DateTime.Parse("10/03/2022")), 
                new Evento("Evento1", DateTime.Parse("15/03/2022")) };
            excpectedEventos[0].YaOcurrio = true;
            excpectedEventos[1].YaOcurrio = false;

            // Act
            List<Evento> eventosSimulados = new List<Evento>() { new Evento("Evento1", DateTime.Parse("10/03/2022")),
                new Evento("Evento1", DateTime.Parse("15/03/2022")) };
            ProcesadorOcurrenciaDeEventos procesadorOcurrenciaDeEventos = new ProcesadorOcurrenciaDeEventos();
            procesadorOcurrenciaDeEventos.procesarOcurrenciaDeEventos(eventosSimulados,DateTime.Now);
            //Assert
            Assert.AreEqual(excpectedEventos[0].YaOcurrio, eventosSimulados[0].YaOcurrio,"dado un evento del pasado, el atributo YaOcurrio debe ser true");
            Assert.AreEqual(excpectedEventos[1].YaOcurrio, eventosSimulados[1].YaOcurrio, "dado un evento del futuro, el atributo YaOcurrio debe ser false");
        }

        [TestMethod()]
        public void calcularTiempoTranscurridoTest()
        {
            // Arrange
            DateTime fechaActual = DateTime.Now;
            int diferencia = 10;
            string rango = "horas";
            DateTime fechaSimulada = fechaActual.AddHours(diferencia);
            String expected =  diferencia +" "+rango;
            //act
            ProcesadorOcurrenciaDeEventos procesadorOcurrenciaDeEventos = new ProcesadorOcurrenciaDeEventos();
            String tiempoTranscurrido = procesadorOcurrenciaDeEventos.calcularTiempoTranscurrido(fechaSimulada, fechaActual);
            Console.WriteLine(tiempoTranscurrido);
            Assert.AreEqual(expected,tiempoTranscurrido,"dada la decha actual y la fecga del evento, determinar el tiempo y rango de ocurrencia");
        }
    }
}