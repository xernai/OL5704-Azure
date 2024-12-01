using System;
using System.Collections.Generic;

namespace ArraysExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1;

            List<int> list = new List<int>();
            list.Add(1);

            // Todas las collections implementan la interface IEnumerable
            int[] calificaciones = new int[4];


            // offset: posicion relativa
            // index: posicion absoluta
            calificaciones[0] = 6;
            calificaciones[1] = 7;
            calificaciones[2] = 8;
            calificaciones[3] = 9;

            // Otra manera de definir y asignar a un array
            int[] calificacionesB = { 5, 6, 10, 9 };


            Console.WriteLine($"Length of calificaciones: {calificaciones.Length}");

            int y = 1;
            y = y + 1; // y++

            Console.WriteLine($"y sin operador de incremento: {y}");
            ++y;

            Console.WriteLine($"y con operador de incremento: {y}");


            for (int i = 0; i < calificaciones.Length; i++) // i: 0, 1, 2, 3 y cuando i sea 4 termina esta estructura for
            {
                Console.WriteLine($"Value of calificaciones[{i}] = {calificaciones[i]}");
            }

            // LINQ usa mucho métodos extensores y Lambda Expressions (delegates)
            // 2 tipos de delegados que ya vienen construidos: Action y Func
        }
    }
}
