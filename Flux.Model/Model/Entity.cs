using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Flux.Model.Model
{
    public class Identity<T>
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public T Id;
    }
}
