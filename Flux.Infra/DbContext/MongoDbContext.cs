using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flux.Infra.DbContext
{
    public class MongoDbContext : IMongoDbContext
    {
        private readonly IConfiguration Configuration;

        protected IMongoClient Client { get; set; }

        public IMongoDatabase Database { get; set; }

        public MongoDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
            StartClient();
        }

        public void StartClient()
        {
            Client = new MongoClient(Configuration["MongoDb:ConnectionString"]);
        }

        public IMongoDatabase GetDatabase(string dbName)
        {
            return Client.GetDatabase(dbName);
        }
    }
}
