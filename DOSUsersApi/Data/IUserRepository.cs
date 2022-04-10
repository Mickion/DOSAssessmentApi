using DOSUsersApi.Models;
using System.Collections.Generic;

namespace DOSUsersApi.Data
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAllUsers();

        User GetUserById(int id);
    }
}
