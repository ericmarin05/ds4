

namespace Laboratorio_8_4
{
    internal class Cobertura
    {
    }
}

// propiedades de solo lectura
public class Cobertura
{
    private double radio;

    public Cobertura(double radio)
    {
        this.radio = radio;
    }

    public double Radio
    {
        get { return radio; }
    }
}