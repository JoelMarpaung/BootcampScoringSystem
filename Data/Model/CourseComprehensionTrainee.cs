using System;
using System.Collections.Generic;
using System.Text;
using Data.Base;
using Data.ViewModel;

namespace Data.Model
{
   public class CourseComprehensionTrainee : BaseModel
    {
        public int Value { get; set; }
        public Trainee Trainee { get; set; }
        public CourseComprehension CourseComprehension { get; set; }

        public CourseComprehensionTrainee() { }

        public CourseComprehensionTrainee(CourseComprehensionTraineeVM coursecomprehensiontraineeVM, Trainee trainee, CourseComprehension coursecomprehension)
        {
            this.Value = coursecomprehensiontraineeVM.Value;
            this.Trainee = trainee;
            this.CourseComprehension = coursecomprehension;
            this.CreateDate = DateTimeOffset.Now;
            this.IsDelete = false;

        }

        public void Update(CourseComprehensionTraineeVM coursecomprehensiontraineeVM, Trainee trainee, CourseComprehension coursecomprehension)
        {
            this.Value = coursecomprehensiontraineeVM.Value;
            this.Trainee = trainee;
            this.CourseComprehension = coursecomprehension;
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