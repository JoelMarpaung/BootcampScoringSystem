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
    public class BatchRepository : IBatchRepository
    {

        MyContext myContext = new MyContext();

        public int Create(BatchVM BatchVM)
        {
            int result = 0;
            var push = new Batch(BatchVM);
            myContext.Batchs.Add(push);
            result = myContext.SaveChanges();
            return result;
        }

        public int Delete(int id)
        {
            var delete = myContext.Batchs.Find(id);
            if (delete != null)
            {
                delete.Delete();
                return myContext.SaveChanges();
            }
            return 0;
        }

        public IEnumerable<Batch> Get()
        {
            return myContext.Batchs.ToList();
        }

        public Batch Get(int id)
        {
            return myContext.Batchs.Find(id);
        }
    

        public Batch Get(BatchVM BatchVM)
        {
            throw new NotImplementedException();
        }

        public int Update(int id, BatchVM BatchVM)
        {
            throw new NotImplementedException();
        }
    }
}