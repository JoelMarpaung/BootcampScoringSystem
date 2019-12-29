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
    public class CourseComprehensionTraineeServices : ICourseComprehensionTraineeServices
    {
        int status = 0;
        private ICourseComprehensionTraineeRepository _CourseComprehensionTraineeRepository = new CourseComprehensionTraineeRepository();

        MyContext myContext = new MyContext();


        public int Create(CourseComprehensionTraineeVM courseComprehensionTraineeVM)
        {
            if (string.IsNullOrWhiteSpace(courseComprehensionTraineeVM.Value.ToString()))
            {
                return status;
            }
            else
            {
                return _CourseComprehensionTraineeRepository.Create(courseComprehensionTraineeVM);
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
                return _CourseComprehensionTraineeRepository.Delete(id);
            }
        }

        public IEnumerable<CourseComprehensionTrainee> Get()
        {
            return _CourseComprehensionTraineeRepository.Get();
        }

        public CourseComprehensionTrainee Get(int id)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                var data = status;
            }
            return _CourseComprehensionTraineeRepository.Get(id);
        }

        public CourseComprehensionTrainee Get(CourseComprehensionTraineeVM courseComprehensionTraineeVM)
        {
            if (string.IsNullOrWhiteSpace(courseComprehensionTraineeVM.Value.ToString()))
            {
                var data = status;
            }
            return _CourseComprehensionTraineeRepository.Get(courseComprehensionTraineeVM);
        }

        public IEnumerable<CourseComprehensionTrainee> GetByTrainee(int traineeId)
        {
            return _CourseComprehensionTraineeRepository.GetByTrainee(traineeId);
        }

        public int Update(int id, CourseComprehensionTraineeVM courseComprehensionTraineeVM)
        {
            if (string.IsNullOrWhiteSpace(courseComprehensionTraineeVM.Value.ToString()))
            {
                return status;
            }
            else
            {
                return _CourseComprehensionTraineeRepository.Update(id, courseComprehensionTraineeVM);
            }
        }
    }
}
