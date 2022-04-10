using System;
using DOSUsersApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace DOSUsersApi.Data
{
    public class SqlUserRepository : IUserRepository
    {
        private readonly UserDbContext _dbcontext;

        public SqlUserRepository(UserDbContext userDbContext)
        {
            _dbcontext = userDbContext;
        }
        public IEnumerable<User> GetAllUsers()
        {
            return _dbcontext.Users.ToList();
        }

        public User GetUserById(int id)
        {
            return _dbcontext.Users.FirstOrDefault(p => p.Id == id);
        }
    }
}
