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
            DateTime fechaACtual = DateTime.Now;
            Console.WriteLine(fechaACtual.ToString());
            DateTime fechaSimulada = fechaACtual.AddHours(10);
            Console.WriteLine(fechaSimulada.ToString());
            Console.WriteLine((fechaSimulada - fechaACtual).TotalHours);
            Console.ReadLine();
           
        }
    }
}
