using Data.Model;
using Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services.Interface
{
    public interface ITraineeServices
    {
        IEnumerable<Trainee> Get();
        Trainee Get(int id);
        Trainee Get(TraineeVM traineeVM);
        IEnumerable<Trainee> GetByTrainer(int trainerId);
        int Create(TraineeVM traineeVM);
        int Update(int id, TraineeVM traineeVM);
        int Delete(int id);
    }
}
