using System;
using System.Collections.Generic;
using System.Text;
using Data.Model;
using Data.ViewModel;

namespace Data.Repositories.Interface
{
  public interface IRoleRepository
    {
        IEnumerable<Role> Get();
        Role Get(int id);
        Role Get(RoleVM RoleVM);
        int Create(RoleVM RoleVM);
        int Update(int id, RoleVM RoleVM);
        int Delete(int id);
    }
}
