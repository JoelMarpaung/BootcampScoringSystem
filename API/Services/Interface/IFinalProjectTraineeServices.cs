using Data.Model;
using Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services.Interface
{
    public interface IFinalProjectTraineeServices
    {
        IEnumerable<FinalProjectTrainee> Get();
        FinalProjectTrainee Get(int id);
        FinalProjectTrainee Get(FinalProjectTraineeVM finalProjectTraineeVM);
        IEnumerable<FinalProjectTrainee> GetByTrainee(int traineeId);
        int Create(FinalProjectTraineeVM finalProjectTraineeVM);
        int Update(int id, FinalProjectTraineeVM finalProjectTraineeVM);
        int Delete(int id);
    }
}
