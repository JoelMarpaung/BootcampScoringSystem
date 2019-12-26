using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data.Context;
using Data.Model;
using Data.Repositories.Interface;
using Data.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories
{
    public class AttitudeEmployeeRepository : IAttitudeEmployeeRepository
    {
        MyContext myContext = new MyContext();

        public int Create(AttitudeEmployeeVM AttitudeEmployeeVM)
        {
            int result = 0;
            var employee = myContext.Employees.Find(AttitudeEmployeeVM.Employee);
            var attitude = myContext.Attitudes.Find(AttitudeEmployeeVM.Attitude);
            var push = new AttitudeEmployee(AttitudeEmployeeVM,employee,attitude);
            myContext.AttitudeEmployees.Add(push);
            result = myContext.SaveChanges();
            return result;
        }

        public int Delete(int id)
        {
            var delete = myContext.AttitudeEmployees.Find(id);
            if (delete != null)
            {
                delete.Delete();
                return myContext.SaveChanges();
            }
            return 0;
        }

        public IEnumerable<AttitudeEmployee> Get()
        {
            return myContext.AttitudeEmployees.ToList();
        }

        public AttitudeEmployee Get(int id)
        {
            return myContext.AttitudeEmployees.Find(id);
        }

        public AttitudeEmployee Get(AttitudeEmployeeVM AttitudeEmployeeVM)
        {
            throw new NotImplementedException();
        }

        public int Update(int id, AttitudeEmployeeVM AttitudeEmployeeVM, Employee employee, Attitude attitude)
        {
            var result = 0;
            var update = myContext.AttitudeEmployees.Find(id);
            update.Update(AttitudeEmployeeVM, employee, attitude);
            result = myContext.SaveChanges();
            return result;
        }

        public int Update(int id, AttitudeEmployeeVM AttitudeEmployeeVM)
        {
            throw new NotImplementedException();
        }
    }
}
