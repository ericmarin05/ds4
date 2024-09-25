using System;

class Program
{
    static void Main()
    {
        // Pedir el precio del producto
        decimal precio;
        do
        {
            Console.Write("Introduce el precio del producto (valor positivo): ");
        } while (!decimal.TryParse(Console.ReadLine(), out precio) || precio <= 0);

        // Pedir la forma de pago
        string formaDePago;
        do
        {
            Console.Write("Introduce la forma de pago (efectivo o tarjeta): ");
            formaDePago = Console.ReadLine().ToLower();
        } while (formaDePago != "efectivo" && formaDePago != "tarjeta");

        // Si la forma de pago es tarjeta, pedir el número de cuenta
        if (formaDePago == "tarjeta")
        {
            string numeroDeCuenta;
            do
            {
                Console.Write("Introduce el número de cuenta (16 dígitos): ");
                numeroDeCuenta = Console.ReadLine();
            } while (numeroDeCuenta.Length != 16 || !EsNumeroValido(numeroDeCuenta));

            Console.WriteLine("Pago realizado con tarjeta.");
        }
        else
        {
            Console.WriteLine("Pago realizado en efectivo.");
        }

        Console.WriteLine("Gracias por su compra.");
    }

    // Función para verificar que el número de cuenta solo contiene dígitos
    static bool EsNumeroValido(string numero)
    {
        foreach (char c in numero)
        {
            if (!char.IsDigit(c))
                return false;
        }
        return true;
    }
}
