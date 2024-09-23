namespace Laboratorio_8_8
{
    internal class ClaseAbstracta
    {
    }
}
abstract class ClaseAbstracta
{
    // Fuerza la herencia de la clase para definir estos métodos
    protected abstract string tomarValor();
    public abstract string prefixValor(string prefix);

    // Método común
    public void printOut()
    {
        Console.WriteLine(tomarValor());
    }
}

class ClaseConcreta1 : ClaseAbstracta
{
    protected override string tomarValor()
    {
        return "ClaseConcreta1";
    }

    public override string prefixValor(string prefix)
    {
        return $"{prefix} ClaseConcreta1";
    }
}

class ClaseConcreta2 : ClaseAbstracta
{
    protected override string tomarValor()
    {
        return "ClaseConcreta2";
    }

    public override string prefixValor(string prefix)
    {
        return $"{prefix} ClaseConcreta2";
    }
}
