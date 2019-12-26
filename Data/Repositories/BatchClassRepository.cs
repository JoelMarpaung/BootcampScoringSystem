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
   public class BatchClassRepository : IBatchClassRepository
    {
        MyContext myContext = new MyContext();

        public int Create(BatchClassVM BatchClassVM)
        {
            int result = 0;
            var batch = myContext.Batchs.Find(BatchClassVM.Batch);
            var _class = myContext.Classes.Find(BatchClassVM.Class);
            var trainee = myContext.Trainees.Find(BatchClassVM.Trainee);
            var trainer = myContext.Employees.Find(BatchClassVM.Trainer);
            var push = new BatchClass(BatchClassVM,  _class, batch, trainee, trainer);
            myContext.BatchClasses.Add(push);
            result = myContext.SaveChanges();
            return result;
        }

        public int Delete(int id)
        {
            var delete = myContext.BatchClasses.Find(id);
            if (delete != null)
            {
                delete.Delete();
                return myContext.SaveChanges();
            }
            return 0;
        }

        public IEnumerable<BatchClass> Get()
        {
            return myContext.BatchClasses.ToList();
        }

        public BatchClass Get(int id)
        {
            return myContext.BatchClasses.Find(id);
        }

        public BatchClass Get(BatchClassVM BatchClassVM)
        {
            throw new NotImplementedException();
        }

        public int Update(int id, BatchClassVM BatchClassVM,  Class _class, Batch batch, Trainee trainee, Employee trainer)
        {
            var result = 0;
            var update = myContext.BatchClasses.Find(id);
            update.Update(BatchClassVM, _class, batch, trainee, trainer);
            result = myContext.SaveChanges();
            return result;
        }

        public int Update(int id, BatchClassVM BatchClassVM)
        {
            throw new NotImplementedException();
        }
    }
}
