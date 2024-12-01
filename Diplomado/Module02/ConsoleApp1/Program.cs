using System;

namespace LambdaExpressions
{
    delegate void Salute(string name); // Signature del metodos o metodos que cumplan con el tipo de parametro y el tipo de retorno(return)
    class Program
    {
        static void Main(string[] args)
        {
            Salute result = delegate (string nombre)
            {
                Console.WriteLine($"Tu nombre en Saludar es: {nombre}");
            };

            result("Jose");
            Console.WriteLine(result);

            // Lambda Expressions
            // 1. Expression Lambda (una sola línea de código)
            // 2. Statement Lambda (varias líneas de código encerradas por llaves)

            // Lambda escenario 1 usando el operador "goes to: =>"
            Salute result1 = (string nombre) =>
            {
                Console.WriteLine($"Tu nombre en Lambda escenario 1 es: {nombre}");
            };

            result1("Jose");
            Console.WriteLine(result1);

            // Lambda escenario 2"
            Salute result2 = (nombre) =>
            {
                Console.WriteLine($"Tu nombre en Lambda escenario 2 es: {nombre}");
            };

            result2("Jose");
            Console.WriteLine(result2);

            // Lambda escenario 3"
            Salute result3 = nombre => Console.WriteLine($"Tu nombre en Lambda escenario 3 es: {nombre}");
            
            result3("Jose");
            Console.WriteLine(result3);
        }

        static string Saludar(string nombre)
        {
            Console.WriteLine($"Tu nombre en Saludar es:{nombre}");
            return $"Tu nombre en Saludar es:{nombre}";
        }    
    }
}
