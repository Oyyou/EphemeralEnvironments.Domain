using EphemeralEnvironments.Domain.Models;
using MongoDB.Bson;
using MongoDB.Driver;

namespace EphemeralEnvironments.Domain.Repositories
{
    public class MongoRepository
    {
        private readonly IMongoCollection<CreateVibeDocument> _collection;

        public MongoRepository(string connectionString, string databaseName, string collectionName)
        {
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(databaseName);
            database.RunCommand((Command<BsonDocument>)"{ping:1}");
            _collection = database.GetCollection<CreateVibeDocument>(collectionName);
        }

        public void InsertDocument(CreateVibeDocument document)
        {
            _collection.InsertOne(document);
        }
    }
}
