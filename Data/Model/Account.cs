using Data.Base;
using Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Model
{
    public class Account : BaseModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public Employee Employee { get; set; }
        public Role Role { get; set; }

        public Account() { }

        public Account(AccountVM accountVM, Employee employee, Role role)
        {
            this.UserName = accountVM.UserName;
            this.Password = accountVM.Password;
            this.Employee = employee;
            this.Role = role;
            this.CreateDate = DateTimeOffset.Now;
            this.IsDelete = false;

        }

        public void Update(AccountVM accountVM, Employee employee, Role role)
        {
            this.UserName = accountVM.UserName;
            this.Password = accountVM.Password;
            this.Employee = employee;
            this.Role = role;
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
   