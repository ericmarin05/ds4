namespace Laboratorio8
{
    internal class Persona
    {
    }
}
class Persona
{
    // Campo de cada objeto Persona que almacena su nombre

    public string Nombre;
    // Campo de cada objeto Persona que almacena su edad
    public int Edad;
    // Campo de cada objeto Persona que almacena su NIF

    public string NIF;

    void cumpleaños() // Incrementa en uno la edad de la persona
    {
        Edad++;
    }

    //Contructor de persona 

    public Persona(string nombre, int edad, string nif)
    {
        Nombre = nombre;
        Edad = edad;
        NIF = nif;
    }
}