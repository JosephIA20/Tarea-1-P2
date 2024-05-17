using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1_P2
{
    internal class ExAlumno : Miembrosdelacomunidad
    {
        // Métodos específicos de ExAlumno
        public void Conectar()
        {
            Console.WriteLine($"{Nombre} está conectando con antiguos compañeros.");
        }
    }
}
