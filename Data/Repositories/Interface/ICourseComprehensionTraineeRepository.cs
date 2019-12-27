using System;
using System.Collections.Generic;
using System.Text;
using Data.Model;
using Data.ViewModel;

namespace Data.Repositories.Interface
{
  public  interface ICourseComprehensionTraineeRepository
    {
        IEnumerable<CourseComprehensionTrainee> Get();
        CourseComprehensionTrainee Get(int id);
        CourseComprehensionTrainee Get(CourseComprehensionTraineeVM CourseComprehensionTraineeVM);
        int Create(CourseComprehensionTraineeVM CourseComprehensionTraineeVM);
        int Update(int id, CourseComprehensionTraineeVM CourseComprehensionTraineeVM);
        int Delete(int id);
    }
}
