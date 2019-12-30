using System;
using System.Collections.Generic;
using System.Text;
using Data.Base;
using Data.ViewModel;

namespace Data.Model
{
    public class Trainee : BaseModel
    {
        public int AttitudeScore { get; set; }
        public int ProjectScore { get; set; }
        public int CourseScore { get; set; }
        public int TotalScore { get; set; }
        public Employee Employee { get; set; }
        public Grade Grade { get; set; }
        public BatchClass BatchClass { get; set; }

        public Trainee() { }

        public Trainee(TraineeVM traineeVM, Grade grade, BatchClass batchclass)
        {
            this.AttitudeScore = traineeVM.AttitudeScore;
            this.ProjectScore = traineeVM.ProjectScore;
            this.CourseScore = traineeVM.CourseScore;
            this.Grade = grade;
            this.BatchClass = batchclass;
            this.CreateDate = DateTimeOffset.Now;
            this.IsDelete = false;

        }

        public void Update(TraineeVM traineeVM, Grade grade, BatchClass batchclass)
        {
            this.AttitudeScore = traineeVM.AttitudeScore;
            this.ProjectScore = traineeVM.ProjectScore;
            this.CourseScore = traineeVM.CourseScore;
            this.Grade = grade;
            this.BatchClass = batchclass;
            this.UpdateDate = DateTimeOffset.Now;
            this.IsDelete = false;
        }

        public void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.LocalDateTime;

        }

        public void Update(int id, TraineeVM traineeVM, Grade grade)
        {
            this.AttitudeScore = traineeVM.AttitudeScore;
            this.ProjectScore = traineeVM.ProjectScore;
            this.CourseScore = traineeVM.CourseScore;
            this.TotalScore = traineeVM.TotalScore;
            this.Grade = grade;
            this.UpdateDate = DateTimeOffset.Now;
        }
    }
}
