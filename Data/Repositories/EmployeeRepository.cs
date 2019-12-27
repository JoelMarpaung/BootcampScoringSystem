using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data.Context;
using Data.Model;
using Data.Repositories.Interface;
using Data.ViewModel;

namespace Data.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        MyContext myContext = new MyContext();

        public int Create(EmployeeVM EmployeeVM)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            var delete = myContext.Employees.Find(id);
            if (delete != null)
            {
                delete.Delete();
                return myContext.SaveChanges();
            }
            return 0;
        }

        public IEnumerable<Employee> Get()
        {
            return myContext.Employees.ToList();
        }

        public Employee Get(int id)
        {
            return myContext.Employees.Find(id);
        }

        public Employee Get(EmployeeVM EmployeeVM)
        {
            throw new NotImplementedException();
        }

        public int Update(int id, EmployeeVM EmployeeVM)
        {
            throw new NotImplementedException();
        }
    }
}
