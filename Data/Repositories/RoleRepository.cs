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
    public class RoleRepository : IRoleRepository
    {

        MyContext myContext = new MyContext();
        public int Create(RoleVM RoleVM)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            var delete = myContext.Roles.Find(id);
            if (delete != null)
            {
                delete.Delete();
                return myContext.SaveChanges();
            }
            return 0;
        }

        public IEnumerable<Role> Get()
        {
            return myContext.Roles.ToList();
        }

        public Role Get(int id)
        {
            return myContext.Roles.Find(id);
        }

        public Role Get(RoleVM RoleVM)
        {
            throw new NotImplementedException();
        }

        public int Update(int id, RoleVM RoleVM)
        {
            throw new NotImplementedException();
        }
    }
}
