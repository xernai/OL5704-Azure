using Microsoft.Azure.Cosmos.Fluent;
using Microsoft.Azure.Cosmos;
using System;
using System.Threading.Tasks;

namespace Azure.CosmosDB.PersonCrud
{
    class People
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }

    }

    class Address
    {
        public string City { get; set; }
        public string ZipCode { get; set; }
    }
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // Remote
            // var connectionString =

            // 
            // Local
            var connectionString = "AccountEndpoint=https://localhost:8081/;AccountKey=C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==";

            var client = new CosmosClientBuilder(connectionString)
                                .WithSerializerOptions(new CosmosSerializationOptions
                                {
                                    PropertyNamingPolicy = CosmosPropertyNamingPolicy.CamelCase
                                })
                                .Build();

            var peopleContainer = client.GetContainer("Liverpool", "People");

            var person = new People
            {
                Id = Guid.NewGuid(),
                Name = "Maya",
                Address = new Address
                {
                    City = "Pueba",
                    ZipCode = "20000"
                }
            };

            // await peopleContainer.CreateItemAsync(person);

            // Can write raw SQL, but the iteration is a little annoying.
            var iterator = peopleContainer.GetItemQueryIterator<People>("SELECT * FROM c WHERE " +
                                                                            "c.address.zipCode = '20000'");
            while (iterator.HasMoreResults)
            {
                foreach (var item in (await iterator.ReadNextAsync()).Resource)
                {
                    person = item;
                    Console.WriteLine($"Name is: {person.Name}");
                }
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
