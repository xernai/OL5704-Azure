using System;
using System.Threading.Tasks;

namespace AsyncProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task es una unidad de trabajo que representa que una operación asíncrona
            // TPL: Task Parallel Programming

            // Task.Run crea y ejecuta una tarea
            //Task<int> task = Task.Run(
            //    () => { return 42; }
            //);

            //task.ContinueWith(t =>
            //{

            //    Console.WriteLine(t.Result);
            //});

            Calculate();

            Console.WriteLine("Press ENTER to close...");
            Console.ReadLine();
        }

        static async Task Calculate()
        {
            Task<int> task = Task.Run(
               () => { return 42; }
           );

            int result = await task;

            Console.WriteLine(result);
        }
    }
}
