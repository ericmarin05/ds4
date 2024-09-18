using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System;
using System.Collections.Generic;

class Program
{
    class Estudiantes
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
    }

    static void Main(string[] args)
    {
        List<Estudiantes> estudiantes = new List<Estudiantes>
        {
            new Estudiantes { Nombre = "Ana", Edad = 12 },
            new Estudiantes { Nombre = "Juan", Edad = 10 },
            new Estudiantes { Nombre = "Sofía", Edad = 11 }
        };

        foreach (Estudiantes estudiante in estudiantes)
        {
            Console.WriteLine("Nombre: " + estudiante.Nombre + ", Edad: " + estudiante.Edad);
        }
    }
}
