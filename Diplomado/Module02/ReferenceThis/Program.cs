using System;
using System.Runtime.CompilerServices;

namespace ReferenceThis
{
    class Company
    {
        public string Name { get; set; }
        public Company Corporate { get; set; } // Composition

        public Company(string name)
        {
            Name = name;   
        }

        public void RelationShip(Company enterprise)
        {
            Console.WriteLine($"Nombre del campo de la instancia actual: {this.Name}");
            Corporate = enterprise;

            enterprise.Corporate = this;
        }
    }
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
        public Person(int age, string name, decimal salary)
        {
            this.age = age;
            this.name = name;
            this.salary = salary;
        }

        public void PrintPersonInfo()
        {
            Console.WriteLine($"Nombre: {this.name} y edad es: {this.age}");
        }

        // propiedades para acceder a los backing fields
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Usos de la referencia This
            // 1. Calificar los campos de la clase cuando se les asigna el mismo nombre del campo
            //    a través de los  parámetros del constructor.
            Person person = new Person(30, "Juan", 1000);

            person.PrintPersonInfo();

            // 2. Aplicar la referencia actual de la instancia Company
            Company company1 = new Company("Walmart");
            Company company2 = new Company("Bodega Aurrerá");

            company1.RelationShip(company2);

            Console.WriteLine($"Corporativo: {company1.Name}");
            Console.WriteLine($"Empresa: {company1.Corporate.Name}");
        }
    }
}
