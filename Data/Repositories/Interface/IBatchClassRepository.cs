using System;
using System.Collections.Generic;
using System.Text;
using Data.Model;
using Data.ViewModel;

namespace Data.Repositories.Interface
{
    public interface IBatchClassRepository
    {
        IEnumerable<BatchClass> Get();
        BatchClass Get(int id);
        BatchClass Get(BatchClassVM BatchClassVM);
        int Create(BatchClassVM BatchClassVM);
        int Update(int id, BatchClassVM BatchClassVM);
        int Delete(int id);
    }
}
