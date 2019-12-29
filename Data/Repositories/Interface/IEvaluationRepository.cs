using Data.Model;
using Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories.Interface
{
    public interface IEvaluationRepository
    {
        IEnumerable<Evaluation> Get();
        Evaluation Get(int id);
        Evaluation Get(EvaluationVM evaluationVM);
        int Create(EvaluationVM evaluationVM);
        int Update(int id, EvaluationVM evaluationVM);
        int Delete(int id);
    }
}
