using Data.Base;
using Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;


namespace Data.Model
{
    public class Batch : BaseModel
    {
        public string Name { get; set; }
        public DateTimeOffset JoinDate { get; set; }
        public DateTimeOffset FinishDate { get; set; }

        public Batch() { }

        public Batch(BatchVM batchVM)
        {
            this.Name = batchVM.Name;
            this.JoinDate = batchVM.JoinDate;
            this.FinishDate = batchVM.FinishDate;
            this.CreateDate = DateTimeOffset.Now;
            this.IsDelete = false;

        }

        public void Update(BatchVM batchVM)
        {
            this.Name = batchVM.Name;
            this.JoinDate = batchVM.JoinDate;
            this.FinishDate = batchVM.FinishDate;
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