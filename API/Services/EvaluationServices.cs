using API.Services.Interface;
using Data.Context;
using Data.Model;
using Data.Repositories;
using Data.Repositories.Interface;
using Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
    public class EvaluationServices : IEvaluationServices
    {
        int status = 0;
        private IEvaluationRepository _EvaluationRepository = new EvaluationRepository();

        MyContext myContext = new MyContext();

        public int Create(EvaluationVM evaluationVM)
        {
            if (string.IsNullOrWhiteSpace(evaluationVM.Name))
            {
                return status;
            }
            else
            {
                return _EvaluationRepository.Create(evaluationVM);
            }
        }

        public int Delete(int id)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                return status;
            }
            else
            {
                return _EvaluationRepository.Delete(id);
            }
        }

        public IEnumerable<Evaluation> Get()
        {
            return _EvaluationRepository.Get();
        }

        public Evaluation Get(int id)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                var data = status;
            }
            return _EvaluationRepository.Get(id);
        }

        public Evaluation Get(EvaluationVM evaluationVM)
        {
            if (string.IsNullOrWhiteSpace(evaluationVM.Name))
            {
                var data = status;
            }
            return _EvaluationRepository.Get(evaluationVM);
        }

        public int Update(int id, EvaluationVM evaluationVM)
        {
            if (string.IsNullOrWhiteSpace(evaluationVM.Name))
            {
                return status;
            }
            else
            {
                return _EvaluationRepository.Update(id, evaluationVM);
            }
        }
    }
}