using System;

namespace Delegates
{
    // Delegate es un apuntador a un metodo

    // Los lenguajes que usan OOP tambien usan programacion orientada a Eventos
    // VB6 es un lenguaje orientado a eventos, pero no a OOP
    // 2002 crea .NET donde VB si es 100% orientado a OOP
    // Los eventos son una especie de delegates

    delegate string Salute(string name); // Signature del metodos o metodos que cumplan con el tipo de parametro y el tipo de retorno(return)
    delegate int Sum(int x, int y); // Signature del metodos o metodos que cumplan con el tipo de parametro y el tipo de retorno(return)
    class Program
    {
        static void Main(string[] args)
        {
            var delegateSalute = new Salute(PrintName); // cola: FIFO
            // 1. PrintName
            
            delegateSalute = delegateSalute + Saludar;
            // 1. PrintName
            // 2. Saludar

            string result = delegateSalute("Jose");

            delegateSalute -= PrintName;
            delegateSalute -= Saludar;

            Console.WriteLine(result);
        }

        static string Saludar(string nombre)
        {
            Console.WriteLine($"Tu nombre en Saludar es:{nombre}");
            return $"Tu nombre en Saludar es:{nombre}";
        }

        // EventHandler es el metodo del evento
        static string PrintName(string nombre)
        {
            Console.WriteLine($"Tu nombre en PrintName es:{nombre}");
            return $"Tu nombre en PrintName es:{nombre}";
        }
    }
}

