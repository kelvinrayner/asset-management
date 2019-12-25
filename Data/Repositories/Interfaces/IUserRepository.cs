using Data.Models;
using Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories.Interfaces
{
    public interface IUserRepository
    {
        IEnumerable<Employee> Get();
        Employee Get(int id);
        int Create(EmployeeVM userVM);
        int Update(int id, EmployeeVM userVM);
        int Delete(int id);
    }
}
