using System;

class Aleatorios
{
    // Atributo de tipo Random
    private Random random;

    // Constructor que inicializa el objeto Random
    public Aleatorios()
    {
        random = new Random();
    }

    // Método que genera un número aleatorio entre dos números dados (incluye los límites)
    public int GenerarNumeroEntre(int min, int max)
    {
        return random.Next(min, max + 1); // Random.Next excluye el límite superior, por eso sumamos 1
    }
}

    // Método que genera un arr
