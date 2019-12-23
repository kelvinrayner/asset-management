using Data.Models;
using Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services.Interface
{
    public interface IAccountService
    {
        IEnumerable<Account> Get();
        Account Get(int id);
        int Create(AccountVM accountVM);
        int Update(int id, AccountVM accountVM);
        int Delete(int id);
        Account GetAccount(string username, string password);
    }
}
