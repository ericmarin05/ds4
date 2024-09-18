using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            int[] MyNumbers = { 1, 2, 3 };
            Console.WriteLine(MyNumbers[10]); // This will cause an exception
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Algo salió mal, valide el índice del arreglo.");
        }
        catch (Exception e) // Optional, for catching any other exceptions
        {
            Console.WriteLine($"Error: {e.Message}");
        }
        finally
        {
            Console.WriteLine("Continuación de la aplicación luego del bloque try/catch.");
        }
    }
}
