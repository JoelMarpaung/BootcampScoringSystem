using API.Services.Interface;
using Data.Model;
using Data.Repositories.Interface;
using Data.Repositories;
using Data.ViewModel;
using System;
using System.Collections.Generic;
using Data.Context;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
    public class FinalProjectTraineeServices : IFinalProjectTraineeServices
    {
        int status = 0;
        private IFinalProjectTraineeRepository _FinalProjectTraineeRepository = new FinalProjectTraineeRepository();

        MyContext myContext = new MyContext();
        
        public int Create(FinalProjectTraineeVM finalProjectTraineeVM)
        {
            if (string.IsNullOrWhiteSpace(finalProjectTraineeVM.Value.ToString()))
            {
                return status;
            }
            else
            {
                return _FinalProjectTraineeRepository.Create(finalProjectTraineeVM);
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
                return _FinalProjectTraineeRepository.Delete(id);
            }
        }

        public IEnumerable<FinalProjectTrainee> Get()
        {
            return _FinalProjectTraineeRepository.Get();
        }

        public FinalProjectTrainee Get(int id)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                var data = status;
            }
            return _FinalProjectTraineeRepository.Get(id);
        }

        public FinalProjectTrainee Get(FinalProjectTraineeVM finalProjectTraineeVM)
        {
            if (string.IsNullOrWhiteSpace(finalProjectTraineeVM.Value.ToString()))
            {
                var data = status;
            }
            return _FinalProjectTraineeRepository.Get(finalProjectTraineeVM);
        }

        public IEnumerable<FinalProjectTrainee> GetByTrainee(int traineeId)
        {
            return _FinalProjectTraineeRepository.GetByTrainee(traineeId);
        }

        public int Update(int id, FinalProjectTraineeVM finalProjectTraineeVM)
        {
            if (string.IsNullOrWhiteSpace(finalProjectTraineeVM.Value.ToString()))
            {
                return status;
            }
            else
            {
                return _FinalProjectTraineeRepository.Update(id, finalProjectTraineeVM);
            }
        }
    }
}
