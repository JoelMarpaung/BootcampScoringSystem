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
    public class FinalProjectRepository : IFinalProjectRepository
    {
        MyContext myContext = new MyContext();

        public int Create(FinalProjectVM FinalProjectVM)
        {
            int result = 0;
            var push = new FinalProject(FinalProjectVM);
            myContext.FinalProjects.Add(push);
            result = myContext.SaveChanges();
            return result;
        }

        public int Delete(int id)
        {
            var delete = myContext.FinalProjects.Find(id);
            if (delete != null)
            {
                delete.Delete();
                return myContext.SaveChanges();
            }
            return 0;
        }

        public IEnumerable<FinalProject> Get()
        {
            return myContext.FinalProjects.Where ( f => f.IsDelete == false).ToList();
        }

        public FinalProject Get(int id)
        {
            return myContext.FinalProjects.Find(id);
        }

        public FinalProject Get(FinalProjectVM FinalProjectVM)
        {
            throw new NotImplementedException();
        }

        public int Update(int id, FinalProjectVM FinalProjectVM)
        {
            var result = 0;
            var update = myContext.FinalProjects.Find(id);
            update.Update(FinalProjectVM);
            result = myContext.SaveChanges();
            return result;
        }
    
    }
}
