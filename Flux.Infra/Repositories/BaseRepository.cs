using Flux.Infra.DbContext;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flux.Infra.Repositories
{
    public class BaseRepository<TEntity>
    {
        public IMongoCollection<TEntity> Collection;

        public BaseRepository(IMongoDbContext context, string dbName)
        {
            Collection = context.GetDatabase(dbName).GetCollection<TEntity>(typeof(TEntity).Name);
        }
    }
}
