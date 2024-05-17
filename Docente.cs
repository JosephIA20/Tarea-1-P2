using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1_P2
{
    internal class Docente : Empleado
    {
        // Métodos específicos de Docente
        public void Enseñar()
        {
            Console.WriteLine($"{Nombre} está enseñando.");
        }
    }
}
