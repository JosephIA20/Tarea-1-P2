using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tarea_1_P2
{
    internal class Administrativo: Empleado
    {
        // Métodos específicos de Administrativo
        public void Gestionar()
        {
            Console.WriteLine($"{Nombre} está gestionando tareas administrativas.");
        }
    }
}
