using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos.Modelos
{
    public class Archivo
    {
        private String ruta, nombreArchivo;

        public Archivo(string ruta, string nombreArchivo)
        {
            this.ruta = ruta;
            this.nombreArchivo = nombreArchivo;
        }

        public string Ruta    // the Name property
        {
            get => ruta;
            set => ruta = value;
        }
        public string NombreArchivo    // the Name property
        {
            get => nombreArchivo;
            set => nombreArchivo = value;
        }

    }
}
