using System;
using System.Collections.Generic;
using System.Text;
using Data.Base;
using Data.ViewModel;

namespace Data.Model
{
    public class CourseComprehension : BaseModel
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public Class Class { get; set; }

        public CourseComprehension() { }

        public CourseComprehension(CourseComprehensionVM coursecomprehensionVM, Class _class)
        {
            this.Name = coursecomprehensionVM.Name;
            this.Weight = coursecomprehensionVM.Weight;
            this.Class = _class;
            this.CreateDate = DateTimeOffset.Now;
            this.IsDelete = false;

        }

        public void Update(CourseComprehensionVM coursecomprehensionVM, Class _class)
        {
            this.Name = coursecomprehensionVM.Name;
            this.Weight = coursecomprehensionVM.Weight;
            this.Class = _class;
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


 