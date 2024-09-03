using System;

namespace Laboratorio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            client.FirstName = "Eric";
            client.LastName = "Marin";
            client.Age = 20;
            client.Id = 1;

            Console.WriteLine(client.GetFullName());
        }
    }

    public class Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ushort Age { get; set; }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
    }
}

public class Myclass
{
    public static int valor;
}


using System;

namespace Laboratorio21
{


    public class program
    {
        public static void Main()
        {

            Myclass.valor = 1;
            Console.WriteLine(Myclass.valor);
        }

    }

    public class Myclass 
    { 
      public static int valor;
    }




}



