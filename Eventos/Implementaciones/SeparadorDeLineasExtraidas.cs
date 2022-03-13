using Eventos.Definiciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos.Implementaciones
{
    public class SeparadorDeLineasExtraidas:ISeparadorDeLineasExtraidas
    {
        char CARACTER_PARA_SEPARAR_LINEAS_EXTRAIDAS = ',';
        public List<String[]> obtenerArrayEventoFecha(String[] arrayLineasExtraidas)
        {
            List<String[]> arrayEventoFecha = new List<String[]>();

            foreach (var linea in arrayLineasExtraidas)
            {
                arrayEventoFecha.Add(linea.Split(CARACTER_PARA_SEPARAR_LINEAS_EXTRAIDAS));
            }
            return arrayEventoFecha;
        }
    }
}
