using System;
using System.Collections.Generic;
using System.Text;
using Data.Base;
using Data.ViewModel;

namespace Data.Model
{
    public class AttitudeEmployee : BaseModel
    {
        private AttitudeEmployeeVM attitudeEmployeeVM;

        public int Value { get; set; }
        public Employee Employee { get; set; }
        public Attitude Attitude { get; set; }

        public AttitudeEmployee() { }

        public AttitudeEmployee(AttitudeEmployeeVM attitudeemployeVM, Employee employee, Attitude attitude)
        {
            this.Value = attitudeemployeVM.Value;
            this.Employee = employee;
            this.Attitude = attitude;
            this.CreateDate = DateTimeOffset.Now;
            this.IsDelete = false;

        }

        public void Update(AttitudeEmployeeVM attitudeemployeVM, Employee employee, Attitude attitude)
        {
            this.Value = attitudeemployeVM.Value;
            this.Employee = employee;
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

