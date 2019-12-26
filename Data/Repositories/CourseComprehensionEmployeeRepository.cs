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
    public class CourseComprehensionEmployeeRepository : ICourseComprehensionEmployeeRepository
    {
        MyContext myContext = new MyContext();

        public int Create(CourseComprehensionEmployeeVM CourseComprehensionEmployeeVM)
        {
            int result = 0;
            var employee = myContext.Employees.Find(CourseComprehensionEmployeeVM.Employee);
            var corsecomprehension = myContext.CourseComprehensions.Find(CourseComprehensionEmployeeVM.CourseComprehension);
            var push = new CourseComprehensionEmployee(CourseComprehensionEmployeeVM, employee, corsecomprehension);
            myContext.CourseComprehensionEmployees.Add(push);
            result = myContext.SaveChanges();
            return result;
        }

        public int Delete(int id)
        {
            var delete = myContext.CourseComprehensionEmployees.Find(id);
            if (delete != null)
            {
                delete.Delete();
                return myContext.SaveChanges();
            }
            return 0;
        }

        public IEnumerable<CourseComprehensionEmployee> Get()
        {
            return myContext.CourseComprehensionEmployees.ToList();
        }

        public CourseComprehensionEmployee Get(int id)
        {
            return myContext.CourseComprehensionEmployees.Find(id);
        }

        public CourseComprehensionEmployee Get(CourseComprehensionEmployeeVM CourseComprehensionEmployeeVM)
        {
            throw new NotImplementedException();
        }

        public int Update(int id, CourseComprehensionEmployeeVM CourseComprehensionEmployeeVM, Employee employee, CourseComprehension coursecomprehension)
        {
            var result = 0;
            var update = myContext.CourseComprehensionEmployees.Find(id);
            update.Update(CourseComprehensionEmployeeVM, employee, coursecomprehension);
            result = myContext.SaveChanges();
            return result;
        }

        public int Update(int id, CourseComprehensionEmployeeVM CourseComprehensionEmployeeVM)
        {
            throw new NotImplementedException();
        }
    }
}
