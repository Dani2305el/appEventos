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
    public class LectorDeArchivoTests
    {


        [TestMethod()]
        public void comprobarExistenciaDelArchivoTest()
        {
            // Arrange
            String directorio = @"D:\Proyectos\ProyectosC#\VisualizadorDeEventos\";
            String nombreArchivo = "eventos.txt";
            Archivo archivo = new Archivo(directorio, nombreArchivo);

            // Act
            LectorDeArchivo lector = new LectorDeArchivo();
            bool existe = lector.comprobarExistenciaDelArchivo(archivo);

            // Assert

            Assert.AreEqual(true, existe, "dado un directorio y un nombre de archivo, el archivo existe");
        }

        [TestMethod()]
        public void extraerLineasTest()
        {
            // Arrange
            String directorio = @"D:\Proyectos\ProyectosC#\appEventos\";
            String nombreArchivo = "eventos.txt";
            Archivo archivo = new Archivo(directorio, nombreArchivo);
            LectorDeArchivo lector = new LectorDeArchivo();
            List<String> expectedArray = new List<String> {"evento,fecha"};
            // Act

            List<String> lineasExtraidas =  lector.extraerLineas(archivo);
     
            // Assert
             
            Assert.AreEqual(expectedArray.GetType(), lineasExtraidas.GetType(), "dado un directorio y un nombre de archivo, el archivo existe y se extrajeron las lineas");

        }
    }
}