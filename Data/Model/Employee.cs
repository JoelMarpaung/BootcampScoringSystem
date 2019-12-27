﻿using System;
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
        public Account Account { get; set; }

        public Employee() { }

        public Employee(EmployeeVM employeeVM, Account account)
        {
            this.FirstName = employeeVM.FirstName;
            this.LastName = employeeVM.LastName;
            this.Email = employeeVM.Email;
            this.Account = account;
            this.CreateDate = DateTimeOffset.Now;
            this.IsDelete = false;
        }

        public void Update(EmployeeVM employeeVM, Account account)
        {
            this.FirstName = employeeVM.FirstName;
            this.LastName = employeeVM.LastName;
            this.Email = employeeVM.Email;
            this.Account = account;
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