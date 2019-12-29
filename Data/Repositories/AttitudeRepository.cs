using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data.Context;
using Data.Model;
using Data.Repositories.Interface;
using Data.ViewModel;
using Microsoft.EntityFrameworkCore;
namespace Data.Repositories
{
    public class AttitudeRepository : IAttitudeRepository
    {
        MyContext myContext = new MyContext();

        public int Create(AttitudeVM AttitudeVM)
        {
            int result = 0;
            var push = new Attitude(AttitudeVM);
            myContext.Attitudes.Add(push);
            result = myContext.SaveChanges();
            return result;
        }

        public int Delete(int id)
        {
            var delete = myContext.Attitudes.Find(id);
            if (delete != null)
            {
                delete.Delete();
                return myContext.SaveChanges();
            }
            return 0;
        }

        public IEnumerable<Attitude> Get()
        {
            return myContext.Attitudes.Where(s=>s.IsDelete==false).ToList();
        }

        public Attitude Get(int id)
        {
            return myContext.Attitudes.Find(id);
        }

        public Attitude Get(AttitudeVM AttitudeVM)
        {
            throw new NotImplementedException();
        }

        public int Update(int id, AttitudeVM AttitudeVM)
        {
            var result = 0;
            var update = myContext.Attitudes.Find(id);
            update.Update(AttitudeVM);
            result = myContext.SaveChanges();
            return result;
        }
    }
}
