using MongoDB.Bson.Serialization.Attributes;

namespace EphemeralEnvironments.Domain.Models
{
    public class CreateVibePayload
    {
        [BsonElement("type")]
        public string Type { get; set; }

        [BsonElement("value")]
        public string Value { get; set; }

        [BsonElement("timeAdded")]
        public DateTime TimeAdded { get; set; }
    }
}
