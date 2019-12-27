using Data.Model;
using Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services.Interface
{
    public interface IFinalProjectServices
    {
        IEnumerable<FinalProject> Get();
        FinalProject Get(int id);
        FinalProject Get(FinalProjectVM finalProjectVM);
        int Create(FinalProjectVM finalProjectVM);
        int Update(int id, FinalProjectVM finalProjectVM);
        int Delete(int id);
    }
}
