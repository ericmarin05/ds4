

namespace Laboratorio8
{
    internal class Trabajador
    {
    }
}

class Trabajador : Persona
{
    // Campo de cada objeto Trabajador que almacena cuanto gana

    public int Salario;

    Trabajador(string nombre, int edad, string nif, int salario) : base(nombre, edad, nif)
    {   // Inicializamos cada trajador en base al contructor de Persona
        Salario = salario;
    }