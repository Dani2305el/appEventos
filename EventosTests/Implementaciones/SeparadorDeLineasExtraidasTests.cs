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
    public class SeparadorDeLineasExtraidasTests
    {
        [TestMethod()]
        public void obtenerArrayEventoFechaTest()
        {
            String[] arrayLineasExtraidas = { "evento,fecha" };
            List<String[]> arrayEventoFecha;
            int expectesLongitud = 2;
            SeparadorDeLineasExtraidas separadorDeLineas = new SeparadorDeLineasExtraidas();

            arrayEventoFecha = separadorDeLineas.obtenerArrayEventoFecha(arrayLineasExtraidas);

            Assert.AreEqual(expectesLongitud, arrayEventoFecha[0].Length,"dato un array de lineas separadas por coma, devolver un array {{evento,fecha}}");
        }
    }
}