using Data.Model;
using Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services.Interface
{
    public interface ICourseComprehensionServices
    {
        IEnumerable<CourseComprehension> Get();
        CourseComprehension Get(int id);
        CourseComprehension Get(CourseComprehensionVM courseComprehensionVM);
        IEnumerable<CourseComprehension> GetByClass(int classId);
        int Create(CourseComprehensionVM courseComprehensionVM);
        int Update(int id, CourseComprehensionVM courseComprehensionVM);
        int Delete(int id);
    }
}
