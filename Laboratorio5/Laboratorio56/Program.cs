internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string, string> paisesycapitales = new Dictionary<string, string>()
        {
            { "Francia", "París" },
            { "España", "Madrid" },
            { "Italia", "Roma" }
        };

        foreach (KeyValuePair<string, string> par in paisesycapitales)
        {
            Console.WriteLine("La capital de " + par.Key + " es " + par.Value + ".");
        }
    }
}
