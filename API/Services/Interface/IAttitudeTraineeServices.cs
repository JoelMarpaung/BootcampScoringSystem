using Data.Model;
using Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services.Interface
{
    public interface IAttitudeTraineeServices
    {
        IEnumerable<AttitudeTrainee> Get();
        AttitudeTrainee Get(int id);
        AttitudeTrainee Get(AttitudeTraineeVM attitudeTraineeVM);
        int Create(AttitudeTraineeVM attitudeTraineeVM);
        int Update(int id, AttitudeTraineeVM attitudeTraineeVM);
        int Delete(int id);
    }
}
