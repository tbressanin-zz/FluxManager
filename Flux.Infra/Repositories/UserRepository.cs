using Flux.Domain.Domain;
using Flux.Infra.DbContext;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Flux.Infra.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        static readonly FilterDefinitionBuilder<User> Filter = Builders<User>.Filter;

        static readonly FilterDefinition<User> EmptyFilter = FilterDefinition<User>.Empty;

        static readonly string dbName = "PhantomManager";

        public UserRepository(IMongoDbContext context)
           : base(context, dbName)
        {
        }

        public async Task<List<User>> GetAll()
        {
            var response = await Collection.FindAsync(EmptyFilter);
            return await response.ToListAsync();
        }

        public async Task<User> GetById(string id)
        {
            var response = await Collection.FindAsync(Filter.Eq("_id", ObjectId.Parse(id)));
            return await response.FirstAsync();
        }

        public async Task<User> Insert(User document)
        {
            await Collection.InsertOneAsync(document);
            return document;
        }

        public async Task<User> Update(User document)
        {
            ReplaceOneResult response = await Collection.ReplaceOneAsync(Filter.Eq("_id", ObjectId.Parse(document.Id)), document);
            if (response.MatchedCount == response.ModifiedCount)
            {
                return await GetById(document.Id);
            }
            return null;
        }
    }
}
