using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
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
            return myContext.Trainees.Include(trainee => trainee.BatchClass).ThenInclude(batchclass => batchclass.Batch).Include(trainee => trainee.BatchClass).ThenInclude(batchclass => batchclass.Class).Include(trainee => trainee.BatchClass).ThenInclude(batchclass => batchclass.Trainer).Include(trainee => trainee.Grade).Include(trainee => trainee.Employee).OrderByDescending(trainee=>trainee.Id).ToList();
        }

        public Trainee Get(int id)
        {
            return myContext.Trainees.Include(trainee => trainee.BatchClass).ThenInclude(batchclass => batchclass.Batch).Include(trainee => trainee.BatchClass).ThenInclude(batchclass => batchclass.Class).Include(trainee => trainee.BatchClass).ThenInclude(batchclass => batchclass.Trainer).Include(trainee => trainee.Grade).Include(trainee => trainee.Employee).FirstOrDefault(t=>t.Id==id);
        }

        public Trainee Get(TraineeVM TraineeVM)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Trainee> GetByTrainer(int trainerId)
        {
            return myContext.Trainees.Include(trainee => trainee.BatchClass).ThenInclude(batchclass => batchclass.Batch).Include(trainee => trainee.BatchClass).ThenInclude(batchclass => batchclass.Class).Include(trainee => trainee.BatchClass).ThenInclude(batchclass => batchclass.Trainer).Include(trainee => trainee.Grade).Where(trainee=>trainee.BatchClass.Trainer.Id == trainerId).Include(trainee=>trainee.Employee).OrderByDescending(trainee => trainee.Id).ToList();
        }

        public int Update(int id, TraineeVM TraineeVM)
        {
            var result = 0;
            var grade = myContext.Grades.Find(TraineeVM.Grade);
            var batchclass = myContext.BatchClasses.Find(TraineeVM.BatchClass);
            var update = myContext.Trainees.Find(id);
            update.Update(TraineeVM, grade, batchclass);
            result = myContext.SaveChanges();
            return result;
        }
    }
}
