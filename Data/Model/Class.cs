using Data.Base;
using Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Model
{
    public class Class : BaseModel
    {
        public string Name { get; set; }
        public Batch Batch { get; set; }

        public Class() { }

        public Class(ClassVM classVM, Batch batch)
        {
            this.Name = classVM.Name;
            this.Batch = batch;
            this.CreateDate = DateTimeOffset.Now;
            this.IsDelete = false;

        }

        public void Update(ClassVM classVM, Batch batch)
        {
            this.Name = classVM.Name;
            this.Batch = batch;
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