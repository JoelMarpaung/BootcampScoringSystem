using System;
using System.Collections.Generic;
using System.Text;
using Data.Model;
using Data.ViewModel;

namespace Data.Repositories.Interface
{
    public interface IAccountRepository
    {
        IEnumerable<Account> Get();
        Account Get(int id);
        Account Get(AccountVM AccountVM);
        int Create(AccountVM AccountVM);
        int Update(int id, AccountVM AccountVM);
        int Delete(int id);
    }
}
