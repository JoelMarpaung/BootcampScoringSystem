using Data.Model;
using Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services.Interface
{
    public interface IRoleServices
    {
        IEnumerable<Role> Get();
        Role Get(int id);
        Role Get(RoleVM roleVM);
        int Create(RoleVM roleVM);
        int Update(int id, RoleVM roleVM);
        int Delete(int id);
    }
}
