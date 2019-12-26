using System;
using System.Collections.Generic;
using System.Text;
using Data.Model;
using Data.ViewModel;

namespace Data.Repositories.Interface
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> Get();
        Employee Get(int id);
        Employee Get(EmployeeVM EmployeeVM);
        int Create(EmployeeVM EmployeeVM);
        int Update(int id, EmployeeVM EmployeeVM);
        int Delete(int id);
    }
}
