using Data.Model;
using Data.Repositories.Interface;
using Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories
{
    public class EvaluationRepository : IEvaluationRepository
    {

        public int Create(EvaluationVM evaluationVM)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Evaluation> Get()
        {
            throw new NotImplementedException();
        }

        public Evaluation Get(int id)
        {
            throw new NotImplementedException();
        }

        public Evaluation Get(EvaluationVM evaluationVM)
        {
            throw new NotImplementedException();
        }

        public int Update(int id, EvaluationVM evaluationVM)
        {
            throw new NotImplementedException();
        }
    }
}
