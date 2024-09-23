internal class Program
{
    private static void Main(string[] args)
    {
        Empleado empleado = new Empleado();
        empleado.Nombre = "John Doe";
        Console.WriteLine($"Nombre del empleado: {empleado.Nombre}");

        CuentaBancaria cta = new CuentaBancaria();
        cta.Saldo = 100;
        Console.WriteLine($"El saldo de la cuenta: {cta.Saldo}");
        // probar después con un saldo negativo, para ver la excepción

        Cobertura cobertura = new Cobertura(5);
        Console.WriteLine($"Con una cobertura de: {cobertura.Radio}");
    }
}