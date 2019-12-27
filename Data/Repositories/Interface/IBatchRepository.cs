using System;
using System.Collections.Generic;
using System.Text;
using Data.Model;
using Data.ViewModel;

namespace Data.Repositories.Interface
{
    public interface IBatchRepository
    {
        IEnumerable <Batch> Get();
        Batch Get(int id);
        Batch Get(BatchVM BatchVM);
        int Create(BatchVM BatchVM);
        int Update(int id, BatchVM BatchVM);
        int Delete(int id);
    }
}
