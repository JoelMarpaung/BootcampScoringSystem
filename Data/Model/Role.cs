using Data.Base;
using Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Model
{
    public class Role : BaseModel
    {
        public string Name { get; set; }

        public Role() { }

        public Role(RoleVM roleVM)
        {
            this.Name = roleVM.Name;
            this.CreateDate = DateTimeOffset.Now;
            this.IsDelete = false;

        }

        public void Update(RoleVM roleVM)
        {
            this.Name = roleVM.Name;
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