using System;
using System.Collections.Generic;
using System.Text;
using Data.Model;
using Data.ViewModel;

namespace Data.Repositories.Interface
{
    public interface IAttitudeRepository
    {
        IEnumerable <Attitude> Get();
        Attitude Get(int id);
        Attitude Get(AttitudeVM AttitudeVM);
        int Create(AttitudeVM AttitudeVM);
        int Update(int id, AttitudeVM AttitudeVM);
        int Delete(int id);
    }
}