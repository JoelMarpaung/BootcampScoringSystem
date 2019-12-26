using Data.Model;
using Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services.Interface
{
    public interface IEmployeeServices
    {
        IEnumerable<Employee> Get();
        Employee Get(int id);
        Employee Get(EmployeeVM employeeVM);
        int Create(EmployeeVM employeeVM);
        int Update(int id, EmployeeVM employeeVM);
        int Delete(int id);
    }
}
