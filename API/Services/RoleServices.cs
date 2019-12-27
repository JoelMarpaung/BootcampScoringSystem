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
    public class RoleServices : IRoleServices
    {
        int status = 0;
        private IRoleRepository _RoleRepository = new RoleRepository();

        MyContext myContext = new MyContext();
        
        public int Create(RoleVM roleVM)
        {
            if (string.IsNullOrWhiteSpace(roleVM.Name))
            {
                return status;
            }
            else
            {
                return _RoleRepository.Create(roleVM);
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
                return _RoleRepository.Delete(id);
            }
        }

        public IEnumerable<Role> Get()
        {
            return _RoleRepository.Get();
        }

        public Role Get(int id)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                var data = status;
            }
            return _RoleRepository.Get(id);
        }

        public Role Get(RoleVM roleVM)
        {
            if (string.IsNullOrWhiteSpace(roleVM.Name))
            {
                var data = status;
            }
            return _RoleRepository.Get(roleVM);
        }

        public int Update(int id, RoleVM roleVM)
        {
            if (string.IsNullOrWhiteSpace(roleVM.Name))
            {
                return status;
            }
            else
            {
                return _RoleRepository.Update(id, roleVM);
            }
        }
    }
}
