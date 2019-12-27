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
    public class TraineeRepository : ITraineeRepository
    {
        MyContext myContext = new MyContext();

        public int Create(TraineeVM TraineeVM)
        {
            int result = 0;
            var grade = myContext.Grades.Find(TraineeVM.Grade);
            var batchclass = myContext.BatchClasses.Find(TraineeVM.BatchClass);
            var push = new Trainee(TraineeVM, grade, batchclass);
            myContext.Trainees.Add(push);
            result = myContext.SaveChanges();
            return result;
        }

        public int Delete(int id)
        {
            var delete = myContext.Trainees.Find(id);
            if (delete != null)
            {
                delete.Delete();
                return myContext.SaveChanges();
            }
            return 0;
        }

        public IEnumerable<Trainee> Get()
        {
            return myContext.Trainees.ToList();
        }

        public Trainee Get(int id)
        {
            return myContext.Trainees.Find(id);
        }

        public Trainee Get(TraineeVM TraineeVM)
        {
            throw new NotImplementedException();
        }

        public int Update(int id, TraineeVM TraineeVM, Grade grade, BatchClass batchclass)
        {
            var result = 0;
            var update = myContext.Trainees.Find(id);
            update.Update(TraineeVM, grade, batchclass);
            result = myContext.SaveChanges();
            return result;
        }

        public int Update(int id, TraineeVM TraineeVM)
        {
            throw new NotImplementedException();
        }
    }
}
