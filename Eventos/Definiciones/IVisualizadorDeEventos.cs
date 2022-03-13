using Eventos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos.Definiciones
{
    public interface IVisualizadorDeEventos
    {
        void vizualizarEventos(List<Evento> eventos);
    }
}
