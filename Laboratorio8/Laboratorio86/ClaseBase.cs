namespace Laboratorio_8_6
{
    internal class ClaseBase
    {
    }
}

class ClaseBase
{
    public void test()
    {
        // Código del método test
    }

    public virtual void masTests()
    {
        // Código del método masTests
    }
}

class ClaseHijo : ClaseBase
{
    public override void masTests()
    {
        // Código del método masTests sobreescrito
    }
}
