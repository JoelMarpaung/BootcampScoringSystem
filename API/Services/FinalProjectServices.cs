using API.Services.Interface;
using Data.Model;
using Data.Repositories.Interface;
using Data.ViewModel;
using System;
using System.Collections.Generic;
using Data.Context;
using System.Linq;
using System.Threading.Tasks;
using Data.Repositories;

namespace API.Services
{
    public class FinalProjectServices : IFinalProjectServices
    {
        int status = 0;
        private IFinalProjectRepository _FinalProjectRepository;

        MyContext myContext = new MyContext();

        public FinalProjectServices(IFinalProjectRepository FinalProjectRepository)
        {
            _FinalProjectRepository = FinalProjectRepository;
        }

        public int Create(FinalProjectVM finalProjectVM)
        {
            if (string.IsNullOrWhiteSpace(finalProjectVM.Name))
            {
                return status;
            }
            else
            {
                return _FinalProjectRepository.Create(finalProjectVM);
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
                return _FinalProjectRepository.Delete(id);
            }
        }

        public IEnumerable<FinalProject> Get()
        {
            return _FinalProjectRepository.Get();
        }

        public FinalProject Get(int id)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                var data = status;
            }
            return _FinalProjectRepository.Get(id);
        }

        public FinalProject Get(FinalProjectVM finalProjectVM)
        {
            if (string.IsNullOrWhiteSpace(finalProjectVM.Name))
            {
                var data = status;
            }
            return _FinalProjectRepository.Get(finalProjectVM);
        }

        public int Update(int id, FinalProjectVM finalProjectVM)
        {
            if (string.IsNullOrWhiteSpace(finalProjectVM.Name))
            {
                return status;
            }
            else
            {
                return _FinalProjectRepository.Update(id, finalProjectVM);
            }
        }
    }
}
