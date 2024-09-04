using System;

class CalculosMatematicos
{
    public int Calcular(int a, int b)
    {
        return (a + b) * (a - b);
    }

    
    public double CalculoArea(double radio)
    {
        return Math.PI * radio * radio;
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

        Console.Write("Ingrese el radio del círculo: ");
        double radio = double.Parse(Console.ReadLine());

        double area = calculos.CalculoArea(radio);
        Console.WriteLine($"El área del círculo es: {area}");
    }
}
