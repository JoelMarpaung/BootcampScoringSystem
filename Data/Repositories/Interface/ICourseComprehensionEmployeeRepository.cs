using System;
using System.Collections.Generic;
using System.Text;
using Data.Model;
using Data.ViewModel;

namespace Data.Repositories.Interface
{
  public  interface ICourseComprehensionEmployeeRepository
    {
        IEnumerable<CourseComprehensionEmployee> Get();
        CourseComprehensionEmployee Get(int id);
        CourseComprehensionEmployee Get(CourseComprehensionEmployeeVM CourseComprehensionEmployeeVM);
        int Create(CourseComprehensionEmployeeVM CourseComprehensionEmployeeVM);
        int Update(int id, CourseComprehensionEmployeeVM CourseComprehensionEmployeeVM);
        int Delete(int id);
    }
}
