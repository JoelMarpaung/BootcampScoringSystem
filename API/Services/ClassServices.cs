using API.Services.Interface;
using Data.Model;
using Data.ViewModel;
using Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
    public class ClassServices : IClassServices
    {
        int status = 0;
        private IClassRepository _ClassRepository;

        MyContext myContext = new MyContext();

        public ClassServices(IClassRepository ClassRepository)
        {
            _ClassRepository = ClassRepository;
        }

        public int Create(ClassVM classVM)
        {
            if (string.IsNullOrWhiteSpace(classVM.Name))
            {
                return status;
            }
            else
            {
                return _ClassRepository.Create(classVM);
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
                return _ClassRepository.Delete(id);
            }
        }

        public IEnumerable<Class> Get()
        {
            return _ClassRepository.Get();
        }

        public Class Get(int id)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                var data = status;
            }
            return _ClassRepository.Get(id);
        }

        public Class Get(ClassVM classVM)
        {
            if (string.IsNullOrWhiteSpace(classVM.Name))
            {
                var data = status;
            }
            return _ClassRepository.Get(classVM);
        }

        public int Update(int id, ClassVM classVM)
        {
            if (string.IsNullOrWhiteSpace(classVM.Name))
            {
                return status;
            }
            else
            {
                return _ClassRepository.Update(id, classVM);
            }
        }
    }
}
