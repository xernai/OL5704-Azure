using System;

namespace AnonymousMethods
{
    delegate void Salute(string name);
    internal class Program
    {
        // Los metodos anonimos no son mas que delegados
        static void Main(string[] args)
        {

            //var result = Saludar("Karla");
            //var nombre = "Karla";

            Salute result = delegate (string nombre)
            {
                Console.WriteLine($"Tu nombre en Saludar es: {nombre}");
            };

            // Salute result = new Salute(Saludar);

            result += PrintName;
            result += Hola;

            // Expresiones Lambda: metodos anonimos
            // Linq

            result("Karla");
        }

        static void PrintName(string nombre)
        {
            Console.WriteLine($"Tu nombre en PrintName es: {nombre}");
        }

        //static void Saludar(string nombre)
        //{
        //    Console.WriteLine($"Tu nombre en Saludar es: {nombre}");
        //}

        static void Hola(string nombre)
        {
            Console.WriteLine($"Tu nombre en Hola es: {nombre}");
        }
    }
}
