using Clouds_AWS.Entities;
using Clouds_AWS.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Clouds_AWS.Data
{
    public class UserContext : IUserContext
    {
        public IMongoCollection<User> Users { get; set; }
        public UserContext(IOptions<UserDatabaseSettings> mongoDBSettings)
        {
            MongoClient client = new MongoClient(mongoDBSettings.Value.ConnectionURI);
            IMongoDatabase database = client.GetDatabase(mongoDBSettings.Value.DatabaseName);
            Users = database.GetCollection<User>(mongoDBSettings.Value.CollectionName);
        }
    }
}
