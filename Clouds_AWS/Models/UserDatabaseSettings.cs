using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clouds_AWS.Models
{
    public interface IUserDatabaseSettings
    {
        string ConnectionURI { get; set; }
        string DatabaseName { get; set; }
        string CollectionName { get; set; }
    }
    public class UserDatabaseSettings: IUserDatabaseSettings
    {
        public string ConnectionURI { get; set; } = null!;
        public string DatabaseName { get; set; } = null!;
        public string CollectionName { get; set; } = null!;
    }
}
