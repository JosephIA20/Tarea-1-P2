using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1_P2
{
    internal class Empleado : Miembrosdelacomunidad
    {

        // Atributos
        public decimal Salario { get; set; }
        public string Puesto { get; set; }

        // Métodos
        public void CalcularSalario()
        {
            Console.WriteLine($"El salario de {Nombre} es {Salario}");
        }
    }

}
