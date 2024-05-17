using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1_P2
{
    internal class Maestro :Docente
    {
        // Métodos específicos de Maestro
        public void Evaluar()
        {
            Console.WriteLine($"{Nombre} está evaluando.");
        }
    }
}
