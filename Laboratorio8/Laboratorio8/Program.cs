using System;

public class Trabajador
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string NIF { get; set; }
    public int Salario { get; set; }

    public Trabajador(string nombre, int edad, string nif, int salario)
    {
        Nombre = nombre;
        Edad = edad;
        NIF = nif;
        Salario = salario;
    }
}

public class Program
{
    public static void Main()
    {
        Trabajador p = new Trabajador("Juan", 30, "12345678A", 1000);
        Console.WriteLine("Nombre=" + p.Nombre);
        Console.WriteLine("Edad=" + p.Edad);
        Console.WriteLine("NIF=" + p.NIF);
        Console.WriteLine("Salario=" + p.Salario);
        Console.ReadKey();
    }
}