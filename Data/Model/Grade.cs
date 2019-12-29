using Data.Base;
using Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Model
{
    public class Grade : BaseModel
    {
        public string Name { get; set; }
        public int MaxValue { get; set; }

        public Grade() { }

        public Grade(GradeVM gradeVM)
        {
            this.Name = gradeVM.Name;
            this.MaxValue = gradeVM.MaxValue;
            this.CreateDate = DateTimeOffset.Now;
            this.IsDelete = false;

        }

        public void Update(GradeVM gradeVM)
        {
            this.Name = gradeVM.Name;
            this.MaxValue = gradeVM.MaxValue;
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