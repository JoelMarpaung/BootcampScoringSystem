
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Data.Context;
using Data.Model;
using Data.Repositories.Interface;
using Data.ViewModel;
using Microsoft.EntityFrameworkCore;

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
            return myContext.CourseComprehensions.Include(coursecomprehension => coursecomprehension.Class).Where(s=>s.IsDelete==false);
        }

        public CourseComprehension Get(int id)
        {
            return myContext.CourseComprehensions.Find(id);
        }

        public CourseComprehension Get(CourseComprehensionVM CourseComprehensionVM)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CourseComprehension> GetByClass(int classId)
        {
            return myContext.CourseComprehensions.Include(cc => cc.Class).Where(cc => cc.Class.Id == classId).ToList();
        }

        public int Update(int id, CourseComprehensionVM CourseComprehensionVM)
        {
            var result = 0;
            var _class = myContext.Classes.Find(CourseComprehensionVM.Class);
            var update = myContext.CourseComprehensions.Find(id);
            update.Update(CourseComprehensionVM, _class);
            result = myContext.SaveChanges();
            return result;
        }

    }
}
