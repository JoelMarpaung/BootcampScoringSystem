using System;
using System.Collections.Generic;
using System.Text;
using Data.Base;
using Data.ViewModel;

namespace Data.Model
{
    public class BatchClass : BaseModel
    {
        public Class Class { get; set; }
        public Batch Batch { get; set; }
        public Trainee Trainee { get; set; }
        public Employee Trainer { get; set; }

        public BatchClass() { }

        public BatchClass(BatchClassVM batchclassVM, Class _class, Batch batch, Trainee trainee, Employee trainer)
        {
            this.Class = _class;
            this.Batch = batch;
            this.Trainee = trainee;
            this.Trainer = trainer;
            this.CreateDate = DateTimeOffset.Now;
            this.IsDelete = false;

        }

        public void Update(BatchClassVM batchclassVM, Class _class, Batch batch, Trainee trainee, Employee trainer)
        {
            this.Class = _class;
            this.Batch = batch;
            this.Trainee = trainee;
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

