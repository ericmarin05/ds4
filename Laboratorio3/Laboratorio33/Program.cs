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

    public int CalculoPerimetro(int lado1, int lado2)
    {
        return 2 * (lado1 + lado2);
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

        Console.Write("Ingrese el primer lado del rectángulo: ");
        int lado1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo lado del rectángulo: ");
        int lado2 = int.Parse(Console.ReadLine());

        int perimetro = calculos.CalculoPerimetro(lado1, lado2);
        Console.WriteLine($"El perímetro del rectángulo es: {perimetro}");
    }
}

