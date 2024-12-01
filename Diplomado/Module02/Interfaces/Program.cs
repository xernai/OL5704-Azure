using System;

namespace Interfaces
{
    // 1. Single Responsibility Principle
    // 2. Open Closed Principle
    // 3. Liskov's Substitution Principle
    // 4. Interface Segregation Principle
    // 5. Dependency Inversion Principle

    // Clean Architecture (interfaces)
    // 1. Hexagonal
    // 2. Onion
    // 3. Vertical
    interface IRepository
    {
        // No pueden tener campos
        void Create();   
        void Get();
        void Update();
        void Delete();
    }

    interface IClaves
    {
        void GetId();
    }

    interface IRepositoryQuery
    {
        void Get();
    }

    class Person
    {
        public int Id { get; set; }
    }

    class Company
    {
        public int Id { get; set; }
    }

    interface IRepositoryCommand
    {
        void Create();
        void Update();
        void Delete();
    }

    class RepositoryDB : IRepository, IClaves
    {
        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Get()
        {
            throw new NotImplementedException();
        }

        public void GetId()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }

    class CQRS : IRepository
    {
        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Get()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
    

    /*
    class CqrsQuery : IRepositoryQuery
    {
        public void Get()
        {
            throw new NotImplementedException();
        }
    }

    class CqrsCommand : IRepositoryCommand
    {
        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
    */
    
    
    internal class Program
    {
        static void Main(string[] args)
        {
            RepositoryDB db = new RepositoryDB();
            CQRS cqrs = new CQRS();

            ShowRepositoryDB(db);
            ShowActionsCQRS(cqrs);

            Show(db);
        }

        private static void ShowActionsCQRS(CQRS cqrs)
        {
            Console.WriteLine("CQRS");
        }

        private static void ShowRepositoryDB(RepositoryDB db)
        {
            Console.WriteLine("RepositoryDB");
        }

        private static void Show(IRepository repo)
        {
            Console.WriteLine(repo.GetType());
        }
    }
}
