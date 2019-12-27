using System;
using System.Collections.Generic;
using System.Text;
using Data.Base;
using Data.ViewModel;

namespace Data.Model
{
    public class FinalProject : BaseModel
    {
        public string Name { get; set; }
        public int Weight { get; set; }

        public FinalProject() { }

        public FinalProject(FinalProjectVM finalprojectVM)
        {
            this.Name = finalprojectVM.Name;
            this.Weight = finalprojectVM.Weight;
            this.CreateDate = DateTimeOffset.Now;
            this.IsDelete = false;

        }

        public void Update(FinalProjectVM finalprojectVM)
        {
            this.Name = finalprojectVM.Name;
            this.Weight = finalprojectVM.Weight;
            this.CreateDate = DateTimeOffset.Now;
            this.IsDelete = false;
        }

        public void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.LocalDateTime;

        }
    }
}
