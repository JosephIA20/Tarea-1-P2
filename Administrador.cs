using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1_P2
{
    internal class Administrador : Docente
    {

        // Métodos específicos de Administrador
        public void Administrar()
        {
            Console.WriteLine($"{Nombre} está administrando.");
        }
    }
}
