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
    public class ClassRepository : IClassRepository
    {
        MyContext myContext = new MyContext();
        public int Create(ClassVM ClassVM)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            var delete = myContext.Classes.Find(id);
            if (delete != null)
            {
                delete.Delete();
                return myContext.SaveChanges();
            }
            return 0;
        }

        public IEnumerable<Class> Get()
        {
            return myContext.Classes.ToList();
        }

        public Class Get(int id)
        {
            return myContext.Classes.Find(id);
        }

        public Class Get(ClassVM ClassVM)
        {
            throw new NotImplementedException();
        }

        public int Update(int id, ClassVM ClassVM)
        {
            throw new NotImplementedException();
        }
    }
}
