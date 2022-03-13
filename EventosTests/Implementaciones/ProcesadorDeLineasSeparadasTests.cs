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
    public class ProcesadorDeLineasSeparadasTests
    {
        [TestMethod()]
        public void procesarLineasSeparadasParaGenerarEventoTest()
        {
            // Arrange
            ValidadorFromatoDeFecha validadorFromatoDeFecha = new ValidadorFromatoDeFecha();
            ValidadorLongitudNombreDeEvento validadorLongitudNombreDeEvento = new ValidadorLongitudNombreDeEvento();
            ProcesadorDeLineasSeparadas procesadorDeLineasSeparadas = new ProcesadorDeLineasSeparadas(validadorFromatoDeFecha,validadorLongitudNombreDeEvento);
            List<Evento> expectedEventos = new List<Evento>() { new Evento("Evento1",DateTime.Parse("13/03/2022"))};
            // Act
            List<String[]> LineasSeparadas = new List<String[]>();
            LineasSeparadas.Add(new String[] { "Evento1", "13/03/2022" });
            procesadorDeLineasSeparadas.procesarLineasSeparadasParaGenerarEvento(LineasSeparadas);
            List<Evento> Eventos = procesadorDeLineasSeparadas.recuperarEventosGenerados();
            // Assert
       
           Assert.AreEqual(expectedEventos[0].Nombre,Eventos[0].Nombre,"dado un array de {evento,fecha} regresar el objeto evento creado");
        }
    }
}