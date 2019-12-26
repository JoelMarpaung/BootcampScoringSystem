using System;
using System.Collections.Generic;
using System.Text;
using Data.Model;
using Data.ViewModel;

namespace Data.Repositories.Interface
{
   public interface IAttitudeEmployeeRepository
    {
        IEnumerable<AttitudeEmployee> Get();
        AttitudeEmployee Get(int id);
        AttitudeEmployee Get(AttitudeEmployeeVM AttitudeEmployeeVM);
        int Create(AttitudeEmployeeVM AttitudeEmployeeVM);
        int Update(int id, AttitudeEmployeeVM AttitudeEmployeeVM);
        int Delete(int id);
    }
}
