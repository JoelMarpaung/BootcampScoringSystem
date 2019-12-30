using System;
using System.Collections.Generic;
using System.Text;
using Data.Model;
using Data.ViewModel;

namespace Data.Repositories.Interface
{
   public interface IFinalProjectTraineeRepository
    {
        IEnumerable <FinalProjectTrainee> Get();
        FinalProjectTrainee Get(int id);
        FinalProjectTrainee Get(FinalProjectTraineeVM FinalProjectEmployeeVM);
        IEnumerable<FinalProjectTrainee> GetByTrainee(int traineeId);
        int Create(FinalProjectTraineeVM FinalProjectEmployeeVM);
        int Update(int id, FinalProjectTraineeVM FinalProjectEmployeeVM);
        int Delete(int id);
    }
}
