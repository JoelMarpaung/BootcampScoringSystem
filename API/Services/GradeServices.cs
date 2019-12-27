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
    public class GradeServices : IGradeServices
    {
        int status = 0;
        private IGradeRepository _GradeRepository = new GradeRepository();

        MyContext myContext = new MyContext();
        
        public int Create(GradeVM gradeVM)
        {
            if (string.IsNullOrWhiteSpace(gradeVM.Name))
            {
                return status;
            }
            else
            {
                return _GradeRepository.Create(gradeVM);
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
                return _GradeRepository.Delete(id);
            }
        }

        public IEnumerable<Grade> Get()
        {
            return _GradeRepository.Get();
        }

        public Grade Get(int id)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                var data = status;
            }
            return _GradeRepository.Get(id);
        }

        public Grade Get(GradeVM gradeVM)
        {
            if (string.IsNullOrWhiteSpace(gradeVM.Name))
            {
                var data = status;
            }
            return _GradeRepository.Get(gradeVM);
        }

        public int Update(int id, GradeVM gradeVM)
        {
            if (string.IsNullOrWhiteSpace(gradeVM.Name))
            {
                return status;
            }
            else
            {
                return _GradeRepository.Update(id, gradeVM);
            }
        }
    }
}
