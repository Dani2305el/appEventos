using Eventos.Implementaciones;
using Eventos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String directorio = @"D:\Proyectos\ProyectosC#\appEventos\";
            String nombreArchivo = "eventos.txt";

            Archivo archivo = new Archivo(directorio, nombreArchivo);

            appMain main = new appMain(archivo, new LectorDeArchivo(), new SeparadorDeLineasExtraidas(), new ValidadorFromatoDeFecha(),
                new ValidadorLongitudNombreDeEvento(), new ProcesadorOcurrenciaDeEventos(), new VisualizadorDeEventos());

            main.Iniciar();
           
        }
    }
}
