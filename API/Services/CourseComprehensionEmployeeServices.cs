using API.Services.Interface;
using Data.Context;
using Data.Model;
using Data.Repositories;
using Data.Repositories.Interface;
using Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
    public class CourseComprehensionEmployeeServices : ICourseComprehensionEmployeeServices
    {
        int status = 0;
        private ICourseComprehensionEmployeeRepository _CourseComprehensionEmployeeRepository = new CourseComprehensionEmployeeRepository();

        MyContext myContext = new MyContext();


        public int Create(CourseComprehensionEmployeeVM courseComprehensionEmployeeVM)
        {
            if (string.IsNullOrWhiteSpace(courseComprehensionEmployeeVM.Value.ToString()))
            {
                return status;
            }
            else
            {
                return _CourseComprehensionEmployeeRepository.Create(courseComprehensionEmployeeVM);
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
                return _CourseComprehensionEmployeeRepository.Delete(id);
            }
        }

        public IEnumerable<CourseComprehensionEmployee> Get()
        {
            return _CourseComprehensionEmployeeRepository.Get();
        }

        public CourseComprehensionEmployee Get(int id)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                var data = status;
            }
            return _CourseComprehensionEmployeeRepository.Get(id);
        }

        public CourseComprehensionEmployee Get(CourseComprehensionEmployeeVM courseComprehensionEmployeeVM)
        {
            if (string.IsNullOrWhiteSpace(courseComprehensionEmployeeVM.Value.ToString()))
            {
                var data = status;
            }
            return _CourseComprehensionEmployeeRepository.Get(courseComprehensionEmployeeVM);
        }

        public int Update(int id, CourseComprehensionEmployeeVM courseComprehensionEmployeeVM)
        {
            if (string.IsNullOrWhiteSpace(courseComprehensionEmployeeVM.Value.ToString()))
            {
                return status;
            }
            else
            {
                return _CourseComprehensionEmployeeRepository.Update(id, courseComprehensionEmployeeVM);
            }
        }
    }
}
