using Eventos.Definiciones;
using Eventos.Modelos;
using System;
using System.Collections.Generic;
using System.IO;

namespace Eventos.Implementaciones
{
    public class LectorDeArchivo: ILectorDeArchivo
    {
        public List<String> extraerLineas(Archivo archivo)
        {
            List<String> datosLeidos = new List<String>();

            foreach (string line in File.ReadLines(archivo.Ruta + archivo.NombreArchivo))
            {
                datosLeidos.Add(line);
            }
            return datosLeidos;
        }
        public bool comprobarExistenciaDelArchivo(Archivo archivo)
        {
            return File.Exists(archivo.Ruta + archivo.NombreArchivo);
        }
    }
}
