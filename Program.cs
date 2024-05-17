// See https://aka.ms/new-console-template for more information
using Tarea_1_P2;

public class Programa
{
    public static void Main(string[] args)
    {
        // Crear instancias de las clases
        Docente docente = new Docente { Nombre = "Juan Pérez", Edad = 40, Identificacion = "DNI123456", Salario = 3000, Puesto = "Profesor de Matemáticas" };
        Estudiante estudiante = new Estudiante { Nombre = "Ana Gómez", Edad = 20, Identificacion = "ID78910", Matricula = "20220001" };

        // Usar métodos
        docente.ObtenerInformacion();
        docente.Enseñar();
        estudiante.ObtenerInformacion();
        estudiante.Estudiar();
    }
}