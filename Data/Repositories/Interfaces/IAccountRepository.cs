using Data.Models;
using Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories.Interfaces
{
    public interface IAccountRepository
    {
        IEnumerable<Account> Get();
        Account Get(int id);
        int Create(AccountVM accountVM);
        int Update(int id, AccountVM accountVM);
        int Delete(int id);
        Account GetAccount(string username, string password);
    }
}
