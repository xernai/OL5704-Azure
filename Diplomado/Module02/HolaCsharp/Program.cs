using System;

// OOP
// 1. Abstraction:enfocarse en ciertos detalles
// 2. Inheritance: cierta funcionalidad se puede tomar de la clase base por las clases derivadas
// 3. Polymorphism: 
// 4. Encapsulation: 

namespace HolaCsharp
{
    public class Person
    {
        private int age;
        private string name;
        private decimal salary;

        public int Age {
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

    class Employee : Person
    {
        public int Badge { get; set; }

    }

    class Worker : Person
    {


    }
    internal class Program
    {
        // Datos or state: propiedad o atributos; fields
        // Behavior: methods or functions

        static void Main(string[] args)
        {
            int x = 0;

            Person person = new Person(1);

            person.Age = 30;

            Console.WriteLine("Edad es: " + person.Age.ToString());

            PrintAge();

            // 
            Employee employee = new Employee();
            employee.Badge = 1000;
            employee.Age = 45;

            Console.WriteLine("Edad es desde Employee: " + employee.Age.ToString());

            Console.ReadKey();
        }

        static void PrintAge()
        {
            
        }
    }

    // dotnet build
    // dotnet run
}

