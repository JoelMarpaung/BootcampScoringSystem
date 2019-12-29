using API.Services.Interface;
using Data.Context;
using Data.Model;
using Data.Repositories;
using Data.Repositories.Interface;
using Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
    public class AttitudeTraineeServices : IAttitudeTraineeServices
    {
        int status = 0;
        private IAttitudeTraineeRepository _AttitudeTraineeRepository = new AttitudeTraineeRepository();

        MyContext myContext = new MyContext();
        
        public int Create(AttitudeTraineeVM attitudeTraineeVM)
        {
            if (string.IsNullOrWhiteSpace(attitudeTraineeVM.Value.ToString()))
            {
                return status;
            }
            else
            {
                return _AttitudeTraineeRepository.Create(attitudeTraineeVM);
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
                return _AttitudeTraineeRepository.Delete(id);
            }
        }

        public IEnumerable<AttitudeTrainee> Get()
        {
            return _AttitudeTraineeRepository.Get();
        }

        public AttitudeTrainee Get(int id)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                var data = status;
            }
            return _AttitudeTraineeRepository.Get(id);
        }

        public AttitudeTrainee Get(AttitudeTraineeVM attitudeTraineeVM)
        {
            if (string.IsNullOrWhiteSpace(attitudeTraineeVM.Value.ToString()))
            {
                var data = status;
            }
            return _AttitudeTraineeRepository.Get(attitudeTraineeVM);
        }

        public IEnumerable<AttitudeTrainee> GetByTrainee(int traineeId)
        {
            return _AttitudeTraineeRepository.GetByTrainee(traineeId);
        }

        public int Update(int id, AttitudeTraineeVM attitudeTraineeVM)
        {
            if (string.IsNullOrWhiteSpace(attitudeTraineeVM.Value.ToString()))
            {
                return status;
            }
            else
            {
                return _AttitudeTraineeRepository.Update(id, attitudeTraineeVM);
            }
        }
    }
}
