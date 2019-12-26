using System;
using System.Collections.Generic;
using System.Text;
using Data.Base;
using Data.ViewModel;

namespace Data.Model
{
    public class Employee : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public Employee Trainer { get; set; }
        public Class Class { get; set; }
        public Batch Batch { get; set; }
        public Grade Grade { get; set; }

        public Employee() { }

        public Employee(EmployeeVM employeeVM, Class _class, Batch _batch, Grade grade, Employee trainer)
        {
            this.FirstName = employeeVM.FirstName;
            this.LastName = employeeVM.LastName;
            this.Email = employeeVM.Email;
            this.Trainer = trainer;
            this.Class = _class;
            this.Batch = _batch;
            this.Grade = grade;
            this.CreateDate = DateTimeOffset.Now;
            this.IsDelete = false;
        }

        public void Update(EmployeeVM employeeVM, Batch batch, Class _class, Batch _batch,Grade grade, Employee trainer)
        {
            this.FirstName = employeeVM.FirstName;
            this.LastName = employeeVM.LastName;
            this.Email = employeeVM.Email;
            this.Trainer = trainer;
            this.Class = _class;
            this.Batch = _batch;
            this.Grade = grade;
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