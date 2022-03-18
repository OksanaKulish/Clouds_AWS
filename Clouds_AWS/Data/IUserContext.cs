using Clouds_AWS.Entities;
using MongoDB.Driver;

namespace Clouds_AWS.Data
{
    public interface IUserContext
    {
        IMongoCollection<User> Users { get; }
    }
}
