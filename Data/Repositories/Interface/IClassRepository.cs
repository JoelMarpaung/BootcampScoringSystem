using System;
using System.Collections.Generic;
using System.Text;
using Data.Model;
using Data.ViewModel;

namespace Data.Repositories.Interface
{
  public  interface IClassRepository
    {
        IEnumerable <Class> Get();
        Class Get(int id);
        Class Get(ClassVM ClassVM);
        int Create(ClassVM ClassVM);
        int Update(int id, ClassVM ClassVM);
        int Delete(int id);
    }
}
