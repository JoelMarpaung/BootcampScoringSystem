using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data.Context;
using Data.Model;
using Data.ViewModel;

namespace Data.Repositories.Interface
{
    public class FinalProjectTraineeRepository : IFinalProjectTraineeRepository
    {
        MyContext myContext = new MyContext();
        public int Create(FinalProjectTraineeVM FinalProjectTraineeVM)
        {
            int result = 0;
            var trainee = myContext.Trainees.Find(FinalProjectTraineeVM.Trainee);
            var finalproject = myContext.FinalProjects.Find(FinalProjectTraineeVM.FinalProject);
            var push = new FinalProjectTrainee(FinalProjectTraineeVM, trainee, finalproject);
            myContext.FinalProjectTrainees.Add(push);
            result = myContext.SaveChanges();
            return result;
        }

        public int Delete(int id)
        {
            var delete = myContext.FinalProjectTrainees.Find(id);
            if (delete != null)
            {
                delete.Delete();
                return myContext.SaveChanges();
            }
            return 0;
        }

        public IEnumerable<FinalProjectTrainee> Get()
        {
            return myContext.FinalProjectTrainees.ToList();
        }

        public FinalProjectTrainee Get(int id)
        {
            return myContext.FinalProjectTrainees.Find(id); ;
        }

        public FinalProjectTrainee Get(FinalProjectTraineeVM FinalProjectEmployeeVM)
        {
            throw new NotImplementedException();
        }

        public int Update(int id, FinalProjectTraineeVM FinalProjectEmployeeVM)
        {
            var result = 0;
            var trainee = myContext.Trainees.Find(FinalProjectEmployeeVM.Trainee);
            var finalproject = myContext.FinalProjects.Find(FinalProjectEmployeeVM.FinalProject);
            var update = myContext.FinalProjectTrainees.Find(id);
            update.Update(FinalProjectEmployeeVM, trainee, finalproject);
            result = myContext.SaveChanges();
            return result;
        }
    }
}
