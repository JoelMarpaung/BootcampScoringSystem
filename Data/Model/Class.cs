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
       
        public Class() { }

        public Class(ClassVM classVM)
        {
            this.Name = classVM.Name;
            this.CreateDate = DateTimeOffset.Now;
            this.IsDelete = false;

        }

        public void Update(ClassVM classVM)
        {
            this.Name = classVM.Name;
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