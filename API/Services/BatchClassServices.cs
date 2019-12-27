﻿using API.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
    public class BatchClassServices : IBatchClassServices
    {
        int status = 0;
        private IBatchClassRepository _BatchClassRepository;

        MyContext myContext = new MyContext();

        public BatchClassServices(IBatchClassRepository BatchClassRepository)
        {
            _BatchClassRepository = BatchClassRepository;
        }

        public int Create(BatchClasshVM batchClassVM)
        {
            if (string.IsNullOrWhiteSpace(batchClassVM.FirstName))
            {
                return status;
            }
            else
            {
                return _BatchClassRepository.Create(batchClassVM);
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
                return _BatchClassRepository.Delete(id);
            }
        }

        public IEnumerable<BatchClass> Get()
        {
            return _BatchClassRepository.Get();
        }

        public BatchClass Get(int id)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                var data = status;
            }
            return _BatchClassRepository.Get(id);
        }

        public BatchClass Get(BatchClassVM batchClassVM)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                var data = status;
            }
            return _BatchClassRepository.Get(batchClassVM);
        }

        public int Update(int id, BatchClasshVM batchClassVM)
        {
            if (string.IsNullOrWhiteSpace(batchClassVM.FirstName))
            {
                return status;
            }
            else
            {
                return _BatchClassRepository.Update(id, batchClassVM);
            }
        }
    }
}