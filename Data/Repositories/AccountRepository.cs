using Data.Context;
using Data.Models;
using Data.Repositories.Interfaces;
using Data.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        MyContext _myContext = new MyContext();

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
            var account = _myContext.Accounts.Include(a => a.Employee).Include(a => a.Role).ToList();
            return account;
        }

        public Account Get(int id)
        {
            throw new NotImplementedException();
        }

        public Account GetAccount(string email, string password)
        {
            //var account = _myContext.Accounts.Include("User").Where(a => a.Username == username && a.Password == password).SingleOrDefault();
            var account = _myContext.Accounts.FromSql($"call sp_retrieve_employee({email},{password})").SingleOrDefault();
            if (account.Id != 0)
            {
                int accountId = Convert.ToInt32(account.Id);
                var accountData = _myContext.Accounts.Include("Employee").Include("Role").Where(a => a.Id == accountId).SingleOrDefault();
                return accountData;
            }
            else
            {
                return account;
            }
        }

        public int Update(int id, AccountVM accountVM)
        {
            throw new NotImplementedException();
        }
    }
}
