
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
    public class CourseComprehensionRepository : ICourseComprehensionRepository
    {
        MyContext myContext = new MyContext();

        public int Create(CourseComprehensionVM CourseComprehensionVM)
        {
            int result = 0;
            var classes = myContext.Classes.Find(CourseComprehensionVM.Class);
            var push = new CourseComprehension(CourseComprehensionVM, classes);
            myContext.CourseComprehensions.Add(push);
            result = myContext.SaveChanges();
            return result;
        }

        public int Delete(int id)
        {
            var delete = myContext.CourseComprehensions.Find(id);
            if (delete != null)
            {
                delete.Delete();
                return myContext.SaveChanges();
            }
            return 0;
        }

        public IEnumerable<CourseComprehension> Get()
        {
            return myContext.CourseComprehensions.ToList();
        }

        public CourseComprehension Get(int id)
        {
            return myContext.CourseComprehensions.Find(id);
        }

        public CourseComprehension Get(CourseComprehensionVM CourseComprehensionVM)
        {
            throw new NotImplementedException();
        }

        public int Update(int id, CourseComprehensionVM CourseComprehensionVM, Class _class)
        {
            var result = 0;
            var update = myContext.CourseComprehensions.Find(id);
            update.Update(CourseComprehensionVM, _class);
            result = myContext.SaveChanges();
            return result;
        }

        public int Update(int id, CourseComprehensionVM CourseComprehensionVM)
        {
            throw new NotImplementedException();
        }
    }
}
