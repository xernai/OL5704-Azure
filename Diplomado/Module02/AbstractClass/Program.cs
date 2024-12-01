using System;

namespace AbstractClass
{
    // Las clases abstractas no se pueden instanciar solo heredar
    public abstract class Animal
    {
        private string Name;
        public abstract void Volar();
        public virtual void Caminar()
        {

        }
        protected Animal()
        {
            Console.WriteLine("Estoy en abstract Animal class");
        }
    }

    public class Cat : Animal
    {
        public Cat()
        {
            Console.WriteLine("Estoy en Cat class");
        }

        public override void Volar()
        {
            throw new NotImplementedException();
        }

        public override void Caminar()
        {
            Console.WriteLine("El gato camina");
        }
    }

    public class Fish : Animal
    {
        public Fish()
        {
            Console.WriteLine("Estoy en Fish class");
        }

        public override void Volar()
        {
            throw new NotImplementedException();
        }
    }

    public class Bird : Animal
    {
        public Bird()
        {
            Console.WriteLine("Estoy en Fish class");
        }

        public override void Volar()
        {
           Console.WriteLine("vuela");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Fish fish = new Fish();

            Console.WriteLine("Hello World!");
        }
    }
}

