using API.Services.Interface;
using Data.Model;
using Data.ViewModel;
using Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Repositories.Interface;

namespace API.Id
{
    public class EmployeeServices : IEmployeeServices
    {
        int status = 0;
        private IEmployeeRepository _EmployeeRepository;

        MyContext myContext = new MyContext();

        public EmployeeServices(IEmployeeRepository EmployeeRepository)
        {
            _EmployeeRepository = EmployeeRepository;
        }

        public int Create(EmployeeVM employeeVM)
        {
            if (string.IsNullOrWhiteSpace(employeeVM.FirstName))
            {
                return status;
            }
            else
            {
                return _EmployeeRepository.Create(employeeVM);
            }
        }

        public int Delete(int id)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                return status;
            }
            else
            {
                return _EmployeeRepository.Delete(id);
            }
        }

        public IEnumerable<Employee> Get()
        {
            return _EmployeeRepository.Get();
        }

        public Employee Get(int id)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                var data = status;
            }
            return _EmployeeRepository.Get(id);
        }

        public Employee Get(EmployeeVM employeeVM)
        {
            if (string.IsNullOrWhiteSpace(employeeVM.FirstName))
            {
                var data = status;
            }
            return _EmployeeRepository.Get(employeeVM);
        }

        public int Update(int id, EmployeeVM employeeVM)
        {
            if (string.IsNullOrWhiteSpace(employeeVM.FirstName))
            {
                return status;
            }
            else
            {
                return _EmployeeRepository.Update(id, employeeVM);
            }
        }
    }
}
