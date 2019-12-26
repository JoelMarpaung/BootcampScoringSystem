using System;
using System.Collections.Generic;
using System.Text;
using Data.Base;
using Data.ViewModel;

namespace Data.Model
{
    public class Trainee : BaseModel
    {

        public Batch Batch { get; set; }
        public Class Class { get; set; }
        public Grade Grade { get; set; }
        public Employee Trainer { get; set; }

        public Trainee() { }

        public Trainee(TraineeVM traineeVM, Batch batch, Class _class, Grade grade, Employee trainer)
        {
            this.Batch = batch;
            this.Class = _class;
            this.Grade = grade;
            this.Trainer = trainer;
            this.CreateDate = DateTimeOffset.Now;
            this.IsDelete = false;

        }

        public void Update(TraineeVM traineeVM, Batch batch, Class _class, Grade grade, Employee trainer)
        {
            this.Batch = batch;
            this.Class = _class;
            this.Grade = grade;
            this.Trainer = trainer;
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
