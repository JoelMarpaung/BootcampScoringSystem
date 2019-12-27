using API.Services.Interface;
using Data.Model;
using Data.ViewModel;
using Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Repositories.Interface;
using Data.Repositories;

namespace API.Services
{
    public class AccountServices : IAccountServices
    {
        int status = 0;
        private IAccountRepository _AccountRepository = new AccountRepository();

        MyContext myContext = new MyContext();
        
        public int Create(AccountVM accountVM)
        {
            if (string.IsNullOrWhiteSpace(accountVM.UserName))
            {
                return status;
            }
            else
            {
                return _AccountRepository.Create(accountVM);
            }
        }

        public int Delete(int id)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                return status;
            }
            else
            {
                return _AccountRepository.Delete(id);
            }
        }

        public IEnumerable<Account> Get()
        {
            return _AccountRepository.Get();
        }

        public Account Get(int id)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                var data = status;
            }
            return _AccountRepository.Get(id);
        }

        public Account Get(AccountVM accountVM)
        {
            if (string.IsNullOrWhiteSpace(accountVM.UserName))
            {
                var data = status;
            }
            return _AccountRepository.Get(accountVM);
        }

        public int Update(int id, AccountVM accountVM)
        {
            if (string.IsNullOrWhiteSpace(accountVM.UserName))
            {
                return status;
            }
            else
            {
                return _AccountRepository.Update(id, accountVM);
            }
        }
    }
}
