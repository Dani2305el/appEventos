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
    public class ValidadorFromatoDeFechaTests
    {
        [TestMethod()]
        public void validarFormatoDeFechaTest()
        {
            String fechaSimulada = "13/03/2022 09:00";
            ValidadorFromatoDeFecha validadorFromatoDeFecha = new ValidadorFromatoDeFecha();
            bool expected = true;

            bool fechaValida = validadorFromatoDeFecha.validarFormatoDeFecha(fechaSimulada);

            Assert.AreEqual(expected, fechaValida,"dado un string de fecha, verificar que sea válido");

        }
    }
}