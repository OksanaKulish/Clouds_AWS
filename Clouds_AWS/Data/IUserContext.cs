using Clouds_AWS.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clouds_AWS.Data
{
    public interface IUserContext
    {
        IMongoCollection<User> Users { get; }
    }
}
