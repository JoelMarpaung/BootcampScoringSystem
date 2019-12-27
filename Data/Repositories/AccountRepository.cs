using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data.Context;
using Data.Model;
using Data.Repositories.Interface;
using Data.ViewModel;

namespace Data.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        MyContext myContext = new MyContext();

        public int Create(AccountVM AccountVM)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            var delete = myContext.Accounts.Find(id);
            if (delete != null)
            {
                delete.Delete();
                return myContext.SaveChanges();
            }
            return 0;
        }

        public IEnumerable<Account> Get()
        {
            return myContext.Accounts.ToList();
        }

        public Account Get(int id)
        {
            return myContext.Accounts.Find(id);
        }

        public Account Get(AccountVM AccountVM)
        {
            return myContext.Accounts.Where(a => a.UserName == AccountVM.UserName && a.Password == AccountVM.Password && a.IsDelete == false).FirstOrDefault();

        }

        public int Update(int id, AccountVM AccountVM)
        {
            throw new NotImplementedException();
        }
    }
}
