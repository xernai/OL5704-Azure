using Azure.Data.Tables;
using System;

namespace Azure.Storage.Table.PersonCrud
{
    class PersonEntity : ITableEntity
    {
        public string PartitionKey { get; set; }
        public string RowKey { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }

        public string Phone { get; set; }

        public string Profile { get; set; }

        public string Hobbies { get; set; }

        public DateTimeOffset? Timestamp { get; set; }
        public ETag ETag { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // local connection
            var connectionString = "AccountName=devstoreaccount1;AccountKey=Eby8vdM02xNOcqFlqUwJPLlmEtlCDXJ1OUzFT50uSRZ6IFsuFq2UVErCz4I6tq/K1SZFPTOtr/KBHBeksoGMGw==;DefaultEndpointsProtocol=http;BlobEndpoint=http://127.0.0.1:10000/devstoreaccount1;QueueEndpoint=http://127.0.0.1:10001/devstoreaccount1;TableEndpoint=http://127.0.0.1:10002/devstoreaccount1;";

            // remote connection
            // var connectionString = 

            var tableName = "Person";

            var tableClient = new TableClient(connectionString, tableName);

            // Create the table if it doesn't already exist to verify we've successfully authenticated.
            tableClient.CreateIfNotExists();

            AddEntity(tableClient);
            // Update
            // Delete
            // Get
        }

        static void AddEntity(TableClient tableClient)
        {
            PersonEntity personEntity = new PersonEntity
            {
                PartitionKey = "Person",
                RowKey = "3",
                FirstName = "Sara",
                LastName = "Perez",
                Age = 20,
                Country = "MX",
                Profile = ".NET Developer",
                Hobbies = "Reparar computadoras"
            };
            tableClient.AddEntity(personEntity);
        }
    }
}
