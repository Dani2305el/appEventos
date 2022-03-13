using Microsoft.VisualStudio.TestTools.UnitTesting;
using Eventos.Implementaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos.Implementaciones.Tests
{
    [TestClass()]
    public class VisualizadorDeEventosTests
    {
        [TestMethod()]
        public void obtenerMensajeOcurrenciaTest()
        {
            //String mensajeExpected = "ocurrió hace";
            String mensajeExpected = "ocurrirá dentro de";
            VisualizadorDeEventos visualizadorDeEventos = new VisualizadorDeEventos();
            bool ocurrio = false;

            String mensaje = visualizadorDeEventos.obtenerMensajeOcurrencia(ocurrio);

            Assert.AreEqual(mensajeExpected, mensaje,"dado un booleano que representa la ocurrencia del evento, mostrar si ya ocurrió o va ocurrir");
        }
    }
}