using System;

namespace BuiltinDelegates
{
    // public delegate string MyDelegado(string x, int y); // Func<string, string> 
    public delegate void MyDelegado1(string x);

    internal class Program
    {
        static void Main(string[] args)
        {
            // MyDelegado myDelegado = new MyDelegado(PrintName);

            // string resultado = myDelegado("Ana", 30);

            // Func delegate
            Func<string, int, string> funcDelegate = delegate (string name, int age) { return "Hello " + name + " edad: " + age; };
            Console.WriteLine($"----------------------------------");

            funcDelegate += PrintName;

            var resultFuncDelegate = funcDelegate("Maia", 30);
            Console.WriteLine($"Result from resultFuncDelegate {resultFuncDelegate}");

            // Action delegate
            MyDelegado1 myDelegado = new MyDelegado1(PrintName1);
            myDelegado("Ana");

            Console.WriteLine($"------------- Action ---------------------");
            Action<string> actionDelegate = x => Console.WriteLine($"Value from action delegate: Hello {x}");

            actionDelegate += PrintName1;
            actionDelegate("Maia");
        }

        static string PrintName(string name, int age)
        {
            return $"Mi nombre es: {name} + {age}";
        }

        static void PrintName1(string name)
        {
            Console.WriteLine($"Mi nombre es: {name}");
        }
    }
}
