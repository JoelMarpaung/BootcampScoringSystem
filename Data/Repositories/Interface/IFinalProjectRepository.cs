using System;
using System.Collections.Generic;
using System.Text;
using Data.Model;
using Data.ViewModel;

namespace Data.Repositories.Interface
{
    public interface IFinalProjectRepository
    {
        IEnumerable<FinalProject> Get();
        FinalProject Get(int id);
        FinalProject Get(FinalProjectVM FinalProjectVM);
        int Create(FinalProjectVM FinalProjectVM);
        int Update(int id, FinalProjectVM FinalProjectVM);
        int Delete(int id);
    }
}
