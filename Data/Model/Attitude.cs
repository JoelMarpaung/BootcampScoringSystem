using System;
using System.Collections.Generic;
using System.Text;
using Data.Base;
using Data.ViewModel;

namespace Data.Model
{
    public class Attitude : BaseModel
    {
        public string Name { get; set; }
        public int Weight { get; set; }

        public Attitude() { }

        public Attitude (AttitudeVM attitudeVM)
        {
            this.Name = attitudeVM.Name;
            this.Weight = attitudeVM.Weight;
            this.CreateDate = DateTimeOffset.Now;
            this.IsDelete = false;
        }

        public void Update (AttitudeVM attitudeVM)
        {
            this.Name = attitudeVM.Name;
            this.Weight = attitudeVM.Weight;
            this.UpdateDate = DateTimeOffset.Now;
            this.IsDelete = false;
        }

        public void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.LocalDateTime;
        }
    }
}
