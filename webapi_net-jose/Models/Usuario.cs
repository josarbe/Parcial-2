using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace PruebaAPI.Models
{
    public class Usuario
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Nombre")]
        [JsonProperty("Nombre")]
        public string Name { get; set; }

        public string Contrasena { get; set; }

        public string Correo { get; set; }
    }
}
