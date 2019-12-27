using System;
using System.Collections.Generic;
using System.Text;
using Data.Base;
using Data.ViewModel;
namespace Data.Model
{
   public class FinalProjectTrainee : BaseModel
    {
        public int Value { get; set; } 
        public Trainee Trainee { get; set; }
        public FinalProject FinalProject { get; set; }

        public FinalProjectTrainee() { }

        public FinalProjectTrainee(FinalProjectTraineeVM finalprojecttraineeVM, Trainee trainee, FinalProject finalproject)
        {
            this.Value = finalprojecttraineeVM.Value;
            this.Trainee = trainee;
            this.FinalProject = finalproject;
            this.CreateDate = DateTimeOffset.Now;
            this.IsDelete = false;

        }

        public void Update(FinalProjectTraineeVM finalprojecttraineeVM, Trainee trainee, FinalProject finalproject)
        {
            this.Value = finalprojecttraineeVM.Value;
            this.Trainee = trainee;
            this.FinalProject = finalproject;
            this.UpdateDate = DateTimeOffset.Now;
            this.IsDelete = false;
        }

        public void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.LocalDateTime;

        }
    }
}

