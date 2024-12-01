using System;
using Utilities;

namespace CalculatorHandle
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Calculator calculator = new Calculator();

            int resultado = calculator.Sum(2, 2);
        }
    }
}
