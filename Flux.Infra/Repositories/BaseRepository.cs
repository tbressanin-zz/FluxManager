using Flux.Infra.DbContext;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flux.Infra.Repositories
{
    public class BaseRepository<TEntity>
    {
        public IMongoCollection<TEntity> Collection;

        public BaseRepository(IMongoDbContext context)
        {
            //BaseMap();
            Collection = context.GetDatabase().GetCollection<TEntity>(typeof(TEntity).Name);
        }

        //public void BaseMap()
        //{
        //    BsonClassMap.IsClassMapRegistered(typeof(BsonDocument));
        //    {
        //        BsonClassMap.RegisterClassMap<TEntity>(
        //            (classMap) =>
        //            {
        //                classMap.AutoMap();
        //                classMap.SetIgnoreExtraElements(true);
        //            });
        //    }
        //}
    }
}
