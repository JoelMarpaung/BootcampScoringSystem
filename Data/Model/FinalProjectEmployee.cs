using System;
using System.Collections.Generic;
using System.Text;
using Data.Base;
using Data.ViewModel;
namespace Data.Model
{
   public class FinalProjectEmployee : BaseModel
    {
        public int Value { get; set; } 
        public Employee Employee { get; set; }
        public FinalProject FinalProject { get; set; }

        public FinalProjectEmployee() { }

        public FinalProjectEmployee(FinalProjectEmployeeVM finalprojectemployeeVM, Employee employee, FinalProject finalproject)
        {
            this.Value = finalprojectemployeeVM.Value;
            this.Employee = employee;
            this.FinalProject = finalproject;
            this.CreateDate = DateTimeOffset.Now;
            this.IsDelete = false;

        }

        public void Update(FinalProjectEmployeeVM finalprojectemployeeVM, Employee employee, FinalProject finalproject)
        {
            this.Value = finalprojectemployeeVM.Value;
            this.Employee = employee;
            this.FinalProject = finalproject;
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

