using System;

class Program
{
    public static void Main()
    {
        // Pedir los tres lados del triángulo
        double lado1, lado2, lado3;

        Console.Write("Introduce el primer lado: ");
        lado1 = double.Parse(Console.ReadLine());

        Console.Write("Introduce el segundo lado: ");
        lado2 = double.Parse(Console.ReadLine());

        Console.Write("Introduce el tercer lado: ");
        lado3 = double.Parse(Console.ReadLine());

        // Verificar si se puede formar un triángulo
        if (EsTrianguloValido(lado1, lado2, lado3))
        {
            Console.WriteLine("Se puede formar un triángulo.");

            // Determinar el tipo de triángulo
            if (lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine("El triángulo es equilátero (todos los lados iguales).");
            }
            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                Console.WriteLine("El triángulo es isósceles (dos lados iguales).");
            }
            else
            {
                Console.WriteLine("El triángulo es escaleno (todos los lados diferentes).");
            }
        }
        else
        {
            Console.WriteLine("No se puede formar un triángulo con estos lados.");
        }
    }

    // Función que verifica si los lados pueden formar un triángulo
    static bool EsTrianguloValido(double lado1, double lado2, double lado3)
    {
        return (lado1 + lado2 > lado3) &&
               (lado1 + lado3 > lado2) &&
               (lado2 + lado3 > lado1);
    }
}
