using System;

class Program
{
    static void Main()
    {

        Console.Write("Ingrese un número impar para el tamaño de la matriz (N): ");
        int N = int.Parse(Console.ReadLine());


        if (N % 2 == 0)
        {
            Console.WriteLine("Por favor, ingrese un número impar.");
            return;
        }

        int[,] matriz = new int[N, N];
        Random rnd = new Random();

        for (int i = 0; i < N; i++)
        {
            matriz[i, 1] = rnd.Next(101, 201);

            matriz[i, N - 2] = rnd.Next(101, 201);
        }

        Console.WriteLine(" Matriz generada:");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write(matriz[i, j].ToString().PadLeft(5));
            }
            Console.WriteLine();
        }

        int sumaSegundaColumna = 0;
        int sumaPenultimaColumna = 0;

        for (int i = 0; i < N; i++)
        {
            sumaSegundaColumna += matriz[i, 1];
            sumaPenultimaColumna += matriz[i, N - 2];
        }

        Console.WriteLine("Suma de los valores de la segunda columna: {sumaSegundaColumna}");
        Console.WriteLine("Suma de los valores de la penúltima columna: {sumaPenultimaColumna}");
    }
}
