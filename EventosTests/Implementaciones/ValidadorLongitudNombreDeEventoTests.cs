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
    public class ValidadorLongitudNombreDeEventoTests
    {
        [TestMethod()]
        public void validarLongitudNombreDeEventoTest()
        {
            String nombreSimulado = "Evento 1";
            ValidadorLongitudNombreDeEvento validadorLongitudNombreDeEvento = new ValidadorLongitudNombreDeEvento();
            bool excpected = true;

            bool nombreValido = validadorLongitudNombreDeEvento.validarLongitudNombreDeEvento(nombreSimulado);

            Assert.AreEqual(excpected, nombreValido,"dado un nombre de evento, verificar que la longitud de caracteres sea válido");

        }
    }
}