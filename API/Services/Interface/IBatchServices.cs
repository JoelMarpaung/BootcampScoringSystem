using Data.Model;
using Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services.Interface
{
    public interface IBatchServices
    {
        IEnumerable<Batch> Get();
        Batch Get(int id);
        Batch Get(BatchVM batchVM);
        int Create(BatchVM batchVM);
        int Update(int id, BatchVM batchVM);
        int Delete(int id);
    }
}
