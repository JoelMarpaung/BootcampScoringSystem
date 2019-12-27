using Data.Model;
using Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services.Interface
{
    public interface IClassServices
    {
        IEnumerable<Data.Model.Class> Get();
        Data.Model.Class Get(int id);
        Data.Model.Class Get(ClassVM classVM);
        //int Create(ClassVM classVM);
        //int Update(int id, ClassVM classVM);
        //int Delete(int id);
    }
}
