using Eventos.Definiciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos.Implementaciones
{
    public class ValidadorLongitudNombreDeEvento:IValidadorLongitudNombreDeEvento
    {
        private const int LONGITUD_MAXIMA_DE_EVENTO = 50;
        public bool validarLongitudNombreDeEvento(String nombreEvento)
        {
            if (nombreEvento.Length > LONGITUD_MAXIMA_DE_EVENTO)
            {
                throw new Exception("Nombre de evento demasiado largo");
            }
            return true;
        }
    }
}
