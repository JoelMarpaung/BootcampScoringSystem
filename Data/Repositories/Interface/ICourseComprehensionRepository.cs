using System;
using System.Collections.Generic;
using System.Text;
using Data.Model;
using Data.ViewModel;

namespace Data.Repositories.Interface
{
   public interface ICourseComprehensionRepository
    {
        IEnumerable<CourseComprehension> Get();
        CourseComprehension Get(int id);
        CourseComprehension Get(CourseComprehensionVM CourseComprehensionVM);
        int Create(CourseComprehensionVM CourseComprehensionVM);
        int Update(int id, CourseComprehensionVM CourseComprehensionVM);
        int Delete(int id);
    }
}
