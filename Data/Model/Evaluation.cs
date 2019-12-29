using Data.Base;
using Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Model
{
    public class Evaluation : BaseModel
    {
        public string Name { get; set; }
        public int Weight { get; set; }

        public Evaluation() { }
        public Evaluation(EvaluationVM evaluationVM)
        {
            this.Name = evaluationVM.Name;
            this.Weight = evaluationVM.Weight;
            this.CreateDate = DateTimeOffset.Now;
            this.IsDelete = false;
        }
        public void Update(EvaluationVM evaluationVM)
        {
            this.Name = evaluationVM.Name;
            this.Weight = evaluationVM.Weight;
            this.UpdateDate = DateTimeOffset.Now;
            this.IsDelete = false;
        }
        public void Delete()
        {
            this.DeleteDate = DateTimeOffset.Now.LocalDateTime;
            this.IsDelete = true;
        }
    }
}
