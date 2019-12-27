using API.Services.Interface;
using Data.Model;
using Data.ViewModel;
using Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Repositories.Interface;
using Data.Repositories;

namespace API.Services
{
    public class BatchServices : IBatchServices
    {
        int status = 0;
        private IBatchRepository _BatchRepository = new BatchRepository();

        MyContext myContext = new MyContext();
        
        public int Create(BatchVM batchVM)
        {
            if (string.IsNullOrWhiteSpace(batchVM.Name))
            {
                return status;
            }
            else
            {
                return _BatchRepository.Create(batchVM);
            }
        }

        public int Delete(int id)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                return status;
            }
            else
            {
                return _BatchRepository.Delete(id);
            }
        }

        public IEnumerable<Batch> Get()
        {
            return _BatchRepository.Get();
        }

        public Batch Get(int id)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                var data = status;
            }
            return _BatchRepository.Get(id);
        }

        public Batch Get(BatchVM batchVM)
        {
            if (string.IsNullOrWhiteSpace(batchVM.Name))
            {
                var data = status;
            }
            return _BatchRepository.Get(batchVM);
        }

        public int Update(int id, BatchVM batchVM)
        {
            if (string.IsNullOrWhiteSpace(batchVM.Name))
            {
                return status;
            }
            else
            {
                return _BatchRepository.Update(id, batchVM);
            }
        }
    }
}
