using API.Services.Interface;
using Data.Models;
using Data.Repositories;
using Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
    public class AccountService : IAccountService
    {
        AccountRepository accountRepository = new AccountRepository();

        public int Create(AccountVM accountVM)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Account> Get()
        {
            return accountRepository.Get();
        }

        public Account Get(int id)
        {
            throw new NotImplementedException();
        }

        public Account GetAccount(string username, string password)
        {
            return accountRepository.GetAccount(username, password);
        }

        public int Update(int id, AccountVM accountVM)
        {
            throw new NotImplementedException();
        }
    }
}
