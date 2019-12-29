using Data.Context;
using Data.Model;
using Data.Repositories.Interface;
using Data.ViewModel;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories
{
    public class EvaluationRepository : IEvaluationRepository
    {
        MyContext myContext = new MyContext();

        public int Create(EvaluationVM evaluationVM)
        {
            int result = 0;
            var push = new Evaluation(evaluationVM);
            myContext.Evaluations.Add(push);
            result = myContext.SaveChanges();
            return result;
        }

        public int Delete(int id)
        {
            var delete = myContext.Evaluations.Find(id);
            if (delete != null)
            {
                delete.Delete();
                return myContext.SaveChanges();
            }
            return 0;
        }

        public IEnumerable<Evaluation> Get()
        {
            return myContext.Evaluations.Where(s => s.IsDelete == false).ToList();
        }

        public Evaluation Get(int id)
        {
            return myContext.Evaluations.Find(id);
        }

        public Evaluation Get(EvaluationVM evaluationVM)
        {
            throw new NotImplementedException();
        }

        public int Update(int id, EvaluationVM evaluationVM)
        {
            var result = 0;
            var update = myContext.Evaluations.Find(id);
            update.Update(evaluationVM);
            result = myContext.SaveChanges();
            return result;
        }
    }
}
