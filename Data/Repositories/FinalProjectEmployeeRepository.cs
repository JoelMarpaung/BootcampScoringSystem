using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data.Context;
using Data.Model;
using Data.ViewModel;

namespace Data.Repositories.Interface
{
    public class FinalProjectEmployeeRepository : IFinalProjectEmployeeRepository
    {
        MyContext myContext = new MyContext();
        public int Create(FinalProjectEmployeeVM FinalProjectEmployeeVM)
        {
            int result = 0;
            var employee = myContext.Employees.Find(FinalProjectEmployeeVM.Employee);
            var finalproject = myContext.FinalProjects.Find(FinalProjectEmployeeVM.FinalProject);
            var push = new FinalProjectEmployee(FinalProjectEmployeeVM, employee, finalproject);
            myContext.FinalProjectEmployees.Add(push);
            result = myContext.SaveChanges();
            return result;
        }

        public int Delete(int id)
        {
            var delete = myContext.FinalProjectEmployees.Find(id);
            if (delete != null)
            {
                delete.Delete();
                return myContext.SaveChanges();
            }
            return 0;
        }

        public IEnumerable<FinalProjectEmployee> Get()
        {
            return myContext.FinalProjectEmployees.ToList();
        }

        public FinalProjectEmployee Get(int id)
        {
            return myContext.FinalProjectEmployees.Find(id); ;
        }

        public FinalProjectEmployee Get(FinalProjectEmployeeVM FinalProjectEmployeeVM)
        {
            throw new NotImplementedException();
        }

        public int Update(int id, FinalProjectEmployeeVM FinalProjectEmployeeVM, Employee employee, FinalProject finalproject)
        {
            var result = 0;
            var update = myContext.FinalProjectEmployees.Find(id);
            update.Update(FinalProjectEmployeeVM, employee, finalproject);
            result = myContext.SaveChanges();
            return result;
        }

        public int Update(int id, FinalProjectEmployeeVM FinalProjectEmployeeVM)
        {
            throw new NotImplementedException();
        }
    }
}
