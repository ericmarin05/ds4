using System;

class CalculosMatematicos
{
    public int Calcular(int a, int b)
    {
        return (a + b) * (a - b);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese el primer número (a): ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo número (b): ");
        int b = int.Parse(Console.ReadLine());

        CalculosMatematicos calculos = new CalculosMatematicos();
        int resultado = calculos.Calcular(a, b);

        Console.WriteLine($"El resultado de (a+b)*(a-b) es: {resultado}");
    }
}

