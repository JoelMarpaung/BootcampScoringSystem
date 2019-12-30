using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data.Context;
using Data.Model;
using Data.Repositories.Interface;
using Data.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories
{
    public class CourseComprehensionTraineeRepository : ICourseComprehensionTraineeRepository
    {
        MyContext myContext = new MyContext();

        public int Create(CourseComprehensionTraineeVM CourseComprehensionTraineeVM)
        {
            int result = 0;
            var trainee = myContext.Trainees.Find(CourseComprehensionTraineeVM.Trainee);
            var coursecomprehension = myContext.CourseComprehensions.Find(CourseComprehensionTraineeVM.CourseComprehension);
            var push = new CourseComprehensionTrainee(CourseComprehensionTraineeVM, trainee, coursecomprehension);
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

        public IEnumerable<CourseComprehensionTrainee> GetByTrainee(int traineeId)
        {
            return myContext.CourseComprehensionTrainees.Include(cc => cc.CourseComprehension).Include(cc => cc.Trainee).Where(cc => cc.Trainee.Id == traineeId).ToList();
        }

        public int Update(int id, CourseComprehensionTraineeVM CourseComprehensionTraineeVM)
        {
            var result = 0;
            var trainee = myContext.Trainees.Find(CourseComprehensionTraineeVM.Trainee);
            var coursecomprehension = myContext.CourseComprehensions.Find(CourseComprehensionTraineeVM.CourseComprehension);
            var update = myContext.CourseComprehensionTrainees.Find(id);
            update.Update(CourseComprehensionTraineeVM, trainee, coursecomprehension);
            result = myContext.SaveChanges();
            return result;
        }

       
    }
}
