using Eventos.Definiciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos.Implementaciones
{
    public class ValidadorFromatoDeFecha:IValidadorFormatoDeFecha
    {
        
        public bool validarFormatoDeFecha(String fecha)
        {
            DateTime _fecha;
            if (!DateTime.TryParse(fecha, out _fecha)) 
            {
                throw new Exception("Formato de fecha no válido");
            }
      
            return DateTime.TryParse(fecha,out _fecha);
        }
    }
}
