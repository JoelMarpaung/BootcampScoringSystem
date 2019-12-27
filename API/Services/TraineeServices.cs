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
    public class TraineeServices : ITraineeServices
    {
        int status = 0;
        private ITraineeRepository _TraineeRepository = new TraineeRepository();

        MyContext myContext = new MyContext();

        public int Create(TraineeVM traineeVM)
        {

            return _TraineeRepository.Create(traineeVM);

        }

        public int Delete(int id)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                return status;
            }
            else
            {
                return _TraineeRepository.Delete(id);
            }
        }

        public IEnumerable<Trainee> Get()
        {
            return _TraineeRepository.Get();
        }

        public Trainee Get(int id)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                var data = status;
            }
            return _TraineeRepository.Get(id);
        }

        public Trainee Get(TraineeVM traineeVM)
        {

            return _TraineeRepository.Get(traineeVM);
        }

        public int Update(int id, TraineeVM traineeVM)
        {

            return _TraineeRepository.Update(id, traineeVM);
        }
    }
}
