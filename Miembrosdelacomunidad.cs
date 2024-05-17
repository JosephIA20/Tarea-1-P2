using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1_P2
{
  public class Miembrosdelacomunidad 
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Identificacion { get; set; }

        // Métodos
        public void ObtenerInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}, Identificación: {Identificacion}");
        }
    }

}

