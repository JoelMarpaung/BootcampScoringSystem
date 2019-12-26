using Data.Model;
using Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services.Interface
{
    public interface IAccountServices
    {
        IEnumerable<Account> Get();
        Account Get(int id);
        Account Get(AccountVM accountVM);
        int Create(AccountVM accountVM);
        int Update(int id, AccountVM accountVM);
        int Delete(int id);
    }
}
