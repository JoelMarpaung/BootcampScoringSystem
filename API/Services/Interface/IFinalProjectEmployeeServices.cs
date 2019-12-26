using Data.Model;
using Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services.Interface
{
    public interface IFinalProjectEmployeeServices
    {
        IEnumerable<FinalProjectEmployee> Get();
        FinalProjectEmployee Get(int id);
        FinalProjectEmployee Get(FinalProjectEmployeeVM finalProjectEmployeeVM);
        int Create(FinalProjectEmployeeVM finalProjectEmployeeVM);
        int Update(int id, FinalProjectEmployeeVM finalProjectEmployeeVM);
        int Delete(int id);
    }
}
