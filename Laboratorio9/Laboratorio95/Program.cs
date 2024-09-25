using System;
using System.Collections.Generic;

class Aleatorios
{
    private Random random;

    public Aleatorios()
    {
        random = new Random();
    }

    public int GenerarNumeroEntre(int min, int max)
    {
        return random.Next(min, max + 1); 
    }

   
    public int[] GenerarArregloNoRepetidoEntre(int min, int max, int cantidad)
    {
       
        if (cantidad > (max - min + 1))
        {
            throw new ArgumentException("La cantidad solicitada es mayor que el rango de números posibles.");
        }

        HashSet<int> numerosSet = new HashSet<int>();
        while (numerosSet.Count < cantidad)
        {
            int numero = GenerarNumeroEntre(min, max);
            numerosSet.Add(numero);
        }

        return new List<int>(numerosSet).ToArray();
    }
}

class Program
{
    static void Main()
    {
        Aleatorios aleatorios = new Aleatorios();

        try
        {
            int[] arregloNoRepetido = aleatorios.GenerarArregloNoRepetidoEntre(1, 10, 5);
            Console.WriteLine("Arreglo de números aleatorios no repetidos entre 1 y 10:");
            foreach (int num in arregloNoRepetido)
            {
                Console.WriteLine(num);
            }
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
