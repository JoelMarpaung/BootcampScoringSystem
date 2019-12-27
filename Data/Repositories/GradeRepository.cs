using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data.Context;
using Data.Model;
using Data.Repositories.Interface;
using Data.ViewModel;

namespace Data.Repositories
{
    public class GradeRepository : IGradeRepository
    {
        MyContext myContext = new MyContext();
        public int Create(GradeVM GradeVM)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            var delete = myContext.Grades.Find(id);
            if (delete != null)
            {
                delete.Delete();
                return myContext.SaveChanges();
            }
            return 0;
        }

        public IEnumerable<Grade> Get()
        {
            return myContext.Grades.ToList();
        }

        public Grade Get(int id)
        {
            return myContext.Grades.Find(id);
        }

        public Grade Get(GradeVM GradeVM)
        {
            throw new NotImplementedException();
        }

        public int Update(int id, GradeVM GradeVM)
        {
            throw new NotImplementedException();
        }
    }
}
