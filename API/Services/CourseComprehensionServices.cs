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
    public class CourseComprehensionServices : ICourseComprehensionServices
    {
        int status = 0;
        private ICourseComprehensionRepository _CourseComprehensionRepository;

        MyContext myContext = new MyContext();

        public CourseComprehensionServices(ICourseComprehensionRepository CourseComprehensionRepository)
        {
            _CourseComprehensionRepository = CourseComprehensionRepository;
        }

        public int Create(CourseComprehensionVM courseComprehensionVM)
        {
            if (string.IsNullOrWhiteSpace(courseComprehensionVM.Name))
            {
                return status;
            }
            else
            {
                return _CourseComprehensionRepository.Create(courseComprehensionVM);
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
                return _CourseComprehensionRepository.Delete(id);
            }
        }

        public IEnumerable<CourseComprehension> Get()
        {
            return _CourseComprehensionRepository.Get();
        }

        public CourseComprehension Get(int id)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                var data = status;
            }
            return _CourseComprehensionRepository.Get(id);
        }

        public CourseComprehension Get(CourseComprehensionVM courseComprehensionVM)
        {
            if (string.IsNullOrWhiteSpace(courseComprehensionVM.Name))
            {
                var data = status;
            }
            return _CourseComprehensionRepository.Get(courseComprehensionVM);
        }

        public int Update(int id, CourseComprehensionVM courseComprehensionVM)
        {
            if (string.IsNullOrWhiteSpace(courseComprehensionVM.Name))
            {
                return status;
            }
            else
            {
                return _CourseComprehensionRepository.Update(id, courseComprehensionVM);
            }
        }
    }
}
