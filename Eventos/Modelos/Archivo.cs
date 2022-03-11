using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos.Modelos
{
    public class Archivo
    {
        private String ruta, archivo;

        public Archivo(string ruta, string archivo)
        {
            this.ruta = ruta;
            this.archivo = archivo;
        }
    }
}
