using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace EphemeralEnvironments.Domain.Models
{
    public class CreateVibeDocument
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("payload")]
        public CreateVibePayload Payload { get; set; }
    }
}
