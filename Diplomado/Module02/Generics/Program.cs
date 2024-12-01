using System;

namespace Generics
{
    class ArithmeticIntegers
    {
        public int Sum(int x, int y)
        {
            var result = x + y;
            return result;
        }
    }

    class ArithmeticDouble
    {
        public double Sum(double x, double y)
        {
            var result = x + y;
            return result;
        }
    }

    class Arithmetic<T> where T: struct
    {
        public T Value1 { get; set; }
        //public T Sum(T x, T y)
        //{
        //    var result = x + y;
        //    return result;
        //}
        public void PrintValues(T value1, T value2)
        {
            Console.WriteLine($"Valor {typeof(T)} de los parametros value1 y value2 son: {value1}, {value2}");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            // integers
            var arithmeticIntegers = new ArithmeticIntegers();

            var number1 = 1;
            var number2 = 2;

            var result = arithmeticIntegers.Sum(number1, number2);

            Console.WriteLine($"Valor de la suma de enteros de {number1} y {number2}: {result}");

            // double
            var arithmeticDouble = new ArithmeticDouble();

            double double1 = 1.0d;
            double double2 = 2.0d;

            var resultDouble = arithmeticDouble.Sum(double1, double2);
            Console.WriteLine($"Valor de la suma de double de {double1} y {double2}: {resultDouble}");

            // Generics
            var arithmetic = new Arithmetic<int>();
            arithmetic.Value1 = 'Ñ';

            // Generics usando enteros
            var numberIntGeneric_1 = 1;
            var numberIntGeneric_2 = 2;

            arithmetic.PrintValues(numberIntGeneric_1, numberIntGeneric_2);

            // Generics usando double
            var arithmeticDoubleGeneric = new Arithmetic<double>();

            var numberDoubleGeneric_1 = 1.0;
            var numberDoubleGeneric_2 = 2.0;

            arithmeticDoubleGeneric.PrintValues(numberDoubleGeneric_1, numberDoubleGeneric_2);
        }
    }
}
