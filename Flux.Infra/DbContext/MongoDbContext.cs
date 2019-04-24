using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flux.Infra.DbContext
{
    public class MongoDbContext : IMongoDbContext
    {
        protected IMongoClient Client { get; set; }

        public IMongoDatabase Database { get; set; }


        public MongoDbContext(IConfiguration configuration)
        {
            Client = new MongoClient(configuration["MongoDb:ConnectionString"]);
            Database = Client.GetDatabase("PhantomManager");
        }

        public IMongoDatabase GetDatabase()
        {
            return Database;
        }
    }
}
