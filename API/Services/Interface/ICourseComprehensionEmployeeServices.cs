using Data.Model;
using Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services.Interface
{
    public interface ICourseComprehensionEmployeeServices
    {
        IEnumerable<CourseComprehensionEmployee> Get();
        CourseComprehensionEmployee Get(int id);
        CourseComprehensionEmployee Get(CourseComprehensionEmployeeVM courseComprehensionEmployeeVM);
        int Create(CourseComprehensionEmployeeVM courseComprehensionEmployeeVM);
        int Update(int id, CourseComprehensionEmployeeVM courseComprehensionEmployeeVM);
        int Delete(int id);
    }
}
