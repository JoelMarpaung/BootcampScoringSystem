using Data.Model;
using Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services.Interface
{
    public interface IGradeServices
    {
        IEnumerable<Grade> Get();
        Grade Get(int id);
        Grade Get(GradeVM gradeVM);
        int Create(GradeVM gradeVM);
        int Update(int id, GradeVM gradeVM);
        int Delete(int id);
    }
}
