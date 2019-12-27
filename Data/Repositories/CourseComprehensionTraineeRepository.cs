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
    public class CourseComprehensionTraineeRepository : ICourseComprehensionTraineeRepository
    {
        MyContext myContext = new MyContext();

        public int Create(CourseComprehensionTraineeVM CourseComprehensionTraineeVM)
        {
            int result = 0;
            var trainee = myContext.Trainees.Find(CourseComprehensionTraineeVM.Trainee);
            var corsecomprehension = myContext.CourseComprehensions.Find(CourseComprehensionTraineeVM.CourseComprehension);
            var push = new CourseComprehensionTrainee(CourseComprehensionTraineeVM, trainee, corsecomprehension);
            myContext.CourseComprehensionTrainees.Add(push);
            result = myContext.SaveChanges();
            return result;
        }

        public int Delete(int id)
        {
            var delete = myContext.CourseComprehensionTrainees.Find(id);
            if (delete != null)
            {
                delete.Delete();
                return myContext.SaveChanges();
            }
            return 0;
        }

        public IEnumerable<CourseComprehensionTrainee> Get()
        {
            return myContext.CourseComprehensionTrainees.ToList();
        }

        public CourseComprehensionTrainee Get(int id)
        {
            return myContext.CourseComprehensionTrainees.Find(id);
        }

        public CourseComprehensionTrainee Get(CourseComprehensionTraineeVM CourseComprehensionTraineeVM)
        {
            throw new NotImplementedException();
        }

        public int Update(int id, CourseComprehensionTraineeVM CourseComprehensionTraineeVM, Trainee trainee, CourseComprehension coursecomprehension)
        {
            var result = 0;
            var update = myContext.CourseComprehensionTrainees.Find(id);
            update.Update(CourseComprehensionTraineeVM, trainee, coursecomprehension);
            result = myContext.SaveChanges();
            return result;
        }

        public int Update(int id, CourseComprehensionTraineeVM CourseComprehensionTraineeVM)
        {
            throw new NotImplementedException();
        }
    }
}
