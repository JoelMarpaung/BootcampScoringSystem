using System;
using System.Collections.Generic;
using System.Text;
using Data.Base;
using Data.ViewModel;

namespace Data.Model
{
    public class AttitudeTrainee : BaseModel
    {
        public int Value { get; set; }
        public Trainee Trainee { get; set; }
        public Attitude Attitude { get; set; }

        public AttitudeTrainee() { }

        public AttitudeTrainee(AttitudeTraineeVM attitudetraineeVM, Trainee trainee, Attitude attitude)
        {
            this.Value = attitudetraineeVM.Value;
            this.Trainee = trainee;
            this.Attitude = attitude;
            this.CreateDate = DateTimeOffset.Now;
            this.IsDelete = false;

        }

        public void Update(AttitudeTraineeVM attitudetraineeVM, Trainee trainee, Attitude attitude)
        {
            this.Value = attitudetraineeVM.Value;
            this.Trainee = trainee;
            this.Attitude = attitude;
            this.CreateDate = DateTimeOffset.Now;
            this.IsDelete = false;
        }

        public void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.LocalDateTime;

        }
    }
}

