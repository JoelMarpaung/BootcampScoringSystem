﻿using System;
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
        IEnumerable<Trainee> GetByTrainer(int trainerId);
        IEnumerable<Trainee> GetByBatch(int batchId);
        int SubmitScore(int traineeId);
        int Create(TraineeVM TraineeVM);
        int Update(int id, TraineeVM TraineeVM);
        int Delete(int id);
    }
}
