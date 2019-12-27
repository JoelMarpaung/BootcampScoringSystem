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
            var batch = myContext.Batchs.Find(TraineeVM.Batch);
            var _class = myContext.Classes.Find(TraineeVM.Class);
            var grade = myContext.Grades.Find(TraineeVM.Grade);
            var trainer = myContext.Employees.Find(TraineeVM.Trainer);
            var push = new Trainee(TraineeVM, batch, _class, grade, trainer);
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

        public int Update(int id, TraineeVM TraineeVM, Batch batch, Class _class, Grade grade, Employee trainer)
        {
            var result = 0;
            var update = myContext.Trainees.Find(id);
            update.Update(TraineeVM, batch, _class, grade, trainer);
            result = myContext.SaveChanges();
            return result;
        }

        public int Update(int id, TraineeVM TraineeVM)
        {
            throw new NotImplementedException();
        }
    }
}
