using System;

namespace PracticaVIIMySQLConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Interfaz interfaz = new Interfaz();

            interfaz.menu();

            Console.ReadKey();

        }
    }
}
