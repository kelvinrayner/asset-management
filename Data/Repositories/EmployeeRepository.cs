using Data.Models;
using Data.Repositories.Interfaces;
using Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories
{
    public class EmployeeRepository : IUserRepository
    {
        public int Create(EmployeeVM userVM)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> Get()
        {
            throw new NotImplementedException();
        }

        public Employee Get(int id)
        {
            throw new NotImplementedException();
        }

        public int Update(int id, EmployeeVM userVM)
        {
            throw new NotImplementedException();
        }
    }
}
