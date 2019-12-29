using Data.Model;
using Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services.Interface
{
    public interface ICourseComprehensionTraineeServices
    {
        IEnumerable<CourseComprehensionTrainee> Get();
        CourseComprehensionTrainee Get(int id);
        CourseComprehensionTrainee Get(CourseComprehensionTraineeVM courseComprehensionEmployeeVM);
        IEnumerable<CourseComprehensionTrainee> GetByTrainee(int traineeId);
        int Create(CourseComprehensionTraineeVM courseComprehensionEmployeeVM);
        int Update(int id, CourseComprehensionTraineeVM courseComprehensionEmployeeVM);
        int Delete(int id);
    }
}
