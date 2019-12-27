using Data.Model;
using Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services.Interface
{
    public interface IAttitudeEmployeeServices
    {
        IEnumerable<AttitudeEmployee> Get();
        AttitudeEmployee Get(int id);
        AttitudeEmployee Get(AttitudeEmployeeVM attitudeEmployeeVM);
        int Create(AttitudeEmployeeVM attitudeEmployeeVM);
        int Update(int id, AttitudeEmployeeVM attitudeEmployeeVM);
        int Delete(int id);
    }
}
