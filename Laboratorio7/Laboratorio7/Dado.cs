namespace Laboratorio_7_2
{
    internal class Dado
    {
    }
}
class Dado
{
    private int valor;
    private static Random aleatorio;

    public Dado()
    {
        aleatorio = new Random();
    }
    public void tirar()
    {
        valor = aleatorio.Next(1, 7);
    }
    public void imprimir()
    {
        Console.WriteLine("Valor del dado: " + valor);
    }
    public int retornarValor()
    {
        return valor;
    }
}