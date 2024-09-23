namespace Laboratorio8_2
{
    internal class Cuenta
    {
    }
}

public class Cuenta
{
    private string idCuenta;
    private Cuenta(string prmtIdCuenta)
    {
        this.idCuenta = prmtIdCuenta;
        System.Console.WriteLine("Contructuro Clase Base para cuenta {0}", prmtIdCuenta);

    }
    public virtual void CalcularInteres()
    {
        System.Console.WriteLine("Calculando interes de la cuenta {0}", this.idCuenta);

    }
    public string getIdCuenta()
    {
        return this.idCuenta;
    }
}
public class cuentaCorriente : Cuenta
{
    public cuentaCorriente(string prmtIdCuenta) : base(prmtIdCuenta)
    {
    }
    public override void CalcularInteres()
    {
        System.Console.WriteLine("CuentaCorriente.CalcularIntereses() efectuado para " +
            "la cuenta {0}", getIdCuenta());
    }
}

public class CuentaAhorro : Cuenta
{
    public CuentaAhorro(string prmtIdCuenta) : base(prmtIdCuenta)
    {
    }
    public override void CalcularInteres()
    {
        System.Console.WriteLine("CuentaAhorro.CalcularIntereses() efectuado para " +
            "la cuenta {0}", getIdCuenta());
    }
}