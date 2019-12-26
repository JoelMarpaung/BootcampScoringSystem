using System;
using System.Collections.Generic;
using System.Text;
using Data.Base;
using Data.ViewModel;

namespace Data.Model
{
   public class CourseComprehensionEmployee : BaseModel
    {
        public int Value { get; set; }
        public Employee Employee { get; set; }
        public CourseComprehension CourseComprehension { get; set; }

        public CourseComprehensionEmployee() { }

        public CourseComprehensionEmployee(CourseComprehensionEmployeeVM coursecomprehensionemployeeVM, Employee employee, CourseComprehension coursecomprehension)
        {
            this.Value = coursecomprehensionemployeeVM.Value;
            this.Employee = employee;
            this.CourseComprehension = coursecomprehension;
            this.CreateDate = DateTimeOffset.Now;
            this.IsDelete = false;

        }

        public void Update(CourseComprehensionEmployeeVM coursecomprehensionemployeeVM, Employee employee, CourseComprehension coursecomprehension)
        {
            this.Value = coursecomprehensionemployeeVM.Value;
            this.Employee = employee;
            this.CourseComprehension = coursecomprehension;
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