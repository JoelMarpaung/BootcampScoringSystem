using System;
using System.Collections.Generic;
using System.Text;
using Data.Model;
using Data.ViewModel;

namespace Data.Repositories.Interface
{
   public interface IAttitudeTraineeRepository
    {
        IEnumerable<AttitudeTrainee> Get();
        AttitudeTrainee Get(int id);
        AttitudeTrainee Get(AttitudeTraineeVM AttitudeTraineeVM);
        IEnumerable<AttitudeTrainee> GetByTrainee(int traineeId);
        int Create(AttitudeTraineeVM AttitudeTraineeVM);
        int Update(int id, AttitudeTraineeVM AttitudeTraineeVM);
        int Delete(int id);
    }
}
