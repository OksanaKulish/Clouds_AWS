using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clouds_AWS.Entities
{
    public class User
    {
        [BsonId]
        public string Id { get; set; }
        [BsonElement("name")]
        public string Name { get; set; }
        [BsonElement("companyName")]
        public string CompanyName { get; set; }
        [BsonElement("imageFile")]
        public string ImageFile { get; set; }
    }
}
