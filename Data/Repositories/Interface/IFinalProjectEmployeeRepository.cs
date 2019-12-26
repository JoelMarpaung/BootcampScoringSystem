using System;
using System.Collections.Generic;
using System.Text;
using Data.Model;
using Data.ViewModel;

namespace Data.Repositories.Interface
{
   public interface IFinalProjectEmployeeRepository
    {
        IEnumerable <FinalProjectEmployee> Get();
        FinalProjectEmployee Get(int id);
        FinalProjectEmployee Get(FinalProjectEmployeeVM FinalProjectEmployeeVM);
        int Create(FinalProjectEmployeeVM FinalProjectEmployeeVM);
        int Update(int id, FinalProjectEmployeeVM FinalProjectEmployeeVM);
        int Delete(int id);
    }
}
