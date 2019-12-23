using Data.Models;
using Data.Repositories.Interfaces;
using Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        public int Create(UserVM userVM)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> Get()
        {
            throw new NotImplementedException();
        }

        public User Get(int id)
        {
            throw new NotImplementedException();
        }

        public int Update(int id, UserVM userVM)
        {
            throw new NotImplementedException();
        }
    }
}
