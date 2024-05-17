using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tarea_1_P2
{
    internal class Estudiante : Miembrosdelacomunidad
    {
        // Atributos
        public string Matricula { get; set; }

        // Métodos
        public void Estudiar()
        {
            Console.WriteLine($"{Nombre} está estudiando.");
        }
    }
}
