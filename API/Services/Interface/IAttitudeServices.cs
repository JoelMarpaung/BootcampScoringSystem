using Data.Model;
using Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services.Interface
{
    public interface IAttitudeServices
    {
        IEnumerable<Attitude> Get();
        Attitude Get(int id);
        Attitude Get(AttitudeVM attitudeVM);
        int Create(AttitudeVM attitudeVM);
        int Update(int id, AttitudeVM attitudeVM);
        int Delete(int id);
    }
}
