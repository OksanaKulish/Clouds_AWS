using Clouds_AWS.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clouds_AWS.Repository
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetUsers();
        Task<User> GetUser(string id);
        Task<IEnumerable<User>> GetUserByName(string name);
        Task CreateUser(User user);
        Task<bool> UpdateUser(User user);
        Task<bool> DeleteUser(string id);
    }
}
