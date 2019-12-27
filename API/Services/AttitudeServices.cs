using API.Services.Interface;
using Data.Model;
using Data.Repositories.Interface;
using Data.Context;
using Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Repositories;

namespace API.Services
{
    public class AttitudeServices : IAttitudeServices
    {
        int status = 0;
        private IAttitudeRepository _AttitudeRepository = new AttitudeRepository();

        MyContext myContext = new MyContext();
        
        public int Create(AttitudeVM attitudeVM)
        {
            if (string.IsNullOrWhiteSpace(attitudeVM.Name))
            {
                return status;
            }
            else
            {
                return _AttitudeRepository.Create(attitudeVM);
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
                return _AttitudeRepository.Delete(id);
            }
        }

        public IEnumerable<Attitude> Get()
        {
            return _AttitudeRepository.Get();
        }

        public Attitude Get(int id)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                var data = status;
            }
            return _AttitudeRepository.Get(id);
        }

        public Attitude Get(AttitudeVM attitudeVM)
        {
            if (string.IsNullOrWhiteSpace(attitudeVM.Name))
            {
                var data = status;
            }
            return _AttitudeRepository.Get(attitudeVM);
        }

        public int Update(int id, AttitudeVM attitudeVM)
        {
            if (string.IsNullOrWhiteSpace(attitudeVM.Name))
            {
                return status;
            }
            else
            {
                return _AttitudeRepository.Update(id, attitudeVM);
            }
        }
    }
}
