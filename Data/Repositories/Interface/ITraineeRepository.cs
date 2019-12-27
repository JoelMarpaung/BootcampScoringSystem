using System;
using System.Collections.Generic;
using System.Text;
using Data.Model;
using Data.ViewModel;

namespace Data.Repositories.Interface
{
    public interface ITraineeRepository
    {
        IEnumerable<Trainee> Get();
        Trainee Get(int id);
        Trainee Get(TraineeVM TraineeVM);
        int Create(TraineeVM TraineeVM);
        int Update(int id, TraineeVM TraineeVM);
        int Delete(int id);
    }
}
