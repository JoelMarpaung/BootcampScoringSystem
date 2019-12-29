using Data.Model;
using Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services.Interface
{
    public interface IEvaluationServices
    {
        IEnumerable<Evaluation> Get();
        Evaluation Get(int id);
        Evaluation Get(EvaluationVM evaluationVM);
        int Create(EvaluationVM evaluationVM);
        int Update(int id, EvaluationVM evaluationVM);
        int Delete(int id);
    }
}
