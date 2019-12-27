using System;
using System.Collections.Generic;
using System.Text;
using Data.Model;
using Data.ViewModel;

namespace Data.Repositories.Interface
{
   public interface IGradeRepository
    {
        IEnumerable<Grade> Get();
        Grade Get(int id);
        Grade Get(GradeVM GradeVM);
        int Create(GradeVM GradeVM);
        int Update(int id, GradeVM GradeVM);
        int Delete(int id);
    }
}
