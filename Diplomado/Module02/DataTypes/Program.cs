using System;
using System.Xml.Linq;

namespace DataTypes
{
    public class Person
    {
        private int age;
        private string name;
        private decimal salary;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Name { get; set; }
        public decimal Salary { get; set; }

        // Overloading
        public Person()
        {

        }
        public Person(int age)
        {
            age = age;
        }

        // propiedades para acceder a los backing fields
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Data Types
            // 1. Value
            //    int, struct, double, decimal, float, long, byte
            //    Se guardan en la memoria stack (corta, fast)
            // 2. Reference
            //    string, class, array, interface, delegate
            //    Se guardan en la memoria heap (grande, lenta) que es administrada por la CLR a través del Garbage Collector o GB
            //    Garbage Collector
            //     Gen 0
            //     Gen 1
            //     Gen 2

            // Value
            byte age = 30;

            int year = 2024;

            byte age1 = 50;

            age = age1;

            Console.WriteLine("------------- Asignado age1 a age -----------------------");
            Console.WriteLine($"Valor de age: {age} ");
            Console.WriteLine($"Valor de age1: {age1} ");

            Console.WriteLine("La edad en Main es (before): " + age);
            PrintAge(age);
            Console.WriteLine("La edad en Main es (after): " + age);

            // Reference -string- se reserva memoria en la heap
            // 1. Se guarda su direccion de memoria de la heap en la memoria stack
            string nombre = "Juan";
            string nombre1 = "Juan";

            Console.WriteLine("------------------------------------");
            unsafe
            {
                fixed (char* p = nombre)
                {
                    Console.WriteLine("Memory address of nombre variable: " + (IntPtr)(p));
                }

                fixed (char* p = nombre1)
                {
                    Console.WriteLine("Memory address of nombre1 variable:" + (IntPtr)(p));
                }
            }

            // ReComparación de cadenas (strings)
            // 1. Operador == (compara por referencias o direcciones de memoria)
            // 2. Equals compara por el contenido

            Console.WriteLine("Comparando name contra name1: " + (nombre == nombre1));

            // Boxing y unboxing se aplica a conversiones entre tipos de datos
            object a = 10; // boxing
            int x = (int)a; // unboxing

            object name = "Juan";
            char[] values = { 'J', 'u', 'a', 'n' };
            object myName = new string(values);

            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Valor de name: {name}");
            Console.WriteLine($"Valor de myName: {myName}");

            Console.WriteLine("== operator result is {0}", name == myName);
            Console.WriteLine("Equals method result is {0}", myName.Equals(name));

            // Reference -class-
            Person person1 = new Person();
            person1.Name = "Juan";

            Console.WriteLine($"Valor de person1.Name (before): {person1.Name}");

            Person person2 = new Person();
            person2.Name = "Pedro";

            person1 = person2;
            Console.WriteLine($"Valor de person1.Name (after): {person1.Name}");
        }

        private static void PrintAge(byte edad)
        {
            edad = 50;

            Console.WriteLine("La edad en PrintAge es: " + edad);
            Console.WriteLine($"La edad en PrintAge es: {edad}");
        }

        private static void PrintAge()
        {
            throw new NotImplementedException();
        }
    }
}
