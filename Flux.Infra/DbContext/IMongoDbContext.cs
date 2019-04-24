using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flux.Infra.DbContext
{
    public interface IMongoDbContext
    {
        IMongoDatabase GetDatabase();
    }
}
