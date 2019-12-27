using Data.Model;
using Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services.Interface
{
    public interface IBatchClassServices
    {
        IEnumerable<BatchClass> Get();
        BatchClass Get(int id);
        BatchClass Get(BatchClassVM batchClassVM);
        int Create(BatchClasshVM batchClassVM);
        int Update(int id, BatchClasshVM batchClassVM);
        int Delete(int id);
    }
}
