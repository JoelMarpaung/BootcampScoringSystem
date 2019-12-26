using API.Services.Interface;
using Data.Model;
using Data.Repositories.Interface;
using Data.ViewModel;
using System;
using System.Collections.Generic;
using Data.Context;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
    public class FinalProjectEmployeeServices : IFinalProjectEmployeeServices
    {
        int status = 0;
        private IFinalProjectEmployeeRepository _FinalProjectEmployeeRepository;

        MyContext myContext = new MyContext();
        public FinalProjectEmployeeServices(IFinalProjectEmployeeRepository FinalProjectEmployeeRepository)
        {
            _FinalProjectEmployeeRepository = FinalProjectEmployeeRepository;
        }
        public int Create(FinalProjectEmployeeVM finalProjectEmployeeVM)
        {
            if (string.IsNullOrWhiteSpace(finalProjectEmployeeVM.Value))
            {
                return status;
            }
            else
            {
                return _FinalProjectEmployeeRepository.Create(finalProjectEmployeeVM);
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
                return _FinalProjectEmployeeRepository.Delete(id);
            }
        }

        public IEnumerable<FinalProjectEmployee> Get()
        {
            return _FinalProjectEmployeeRepository.Get();
        }

        public FinalProjectEmployee Get(int id)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                var data = status;
            }
            return _FinalProjectEmployeeRepository.Get(id);
        }

        public FinalProjectEmployee Get(FinalProjectEmployeeVM finalProjectEmployeeVM)
        {
            t if (string.IsNullOrWhiteSpace(finalProjectEmployeeVM.Value))
            {
                var data = status;
            }
            return _FinalProjectEmployeeRepository.Get(finalProjectEmployeeVM);
        }

        public int Update(int id, FinalProjectEmployeeVM finalProjectEmployeeVM)
        {
            if (string.IsNullOrWhiteSpace(finalProjectEmployeeVM.Value))
            {
                return status;
            }
            else
            {
                return _FinalProjectEmployeeRepository.Update(id, finalProjectEmployeeVM);
            }
        }
    }
}
