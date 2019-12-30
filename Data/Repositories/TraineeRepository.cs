using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Data.Context;
using Data.Model;
using Data.Repositories.Interface;
using Data.ViewModel;

namespace Data.Repositories
{
    public class TraineeRepository : ITraineeRepository
    {
        MyContext myContext = new MyContext();

        public int Create(TraineeVM TraineeVM)
        {
            int result = 0;
            var grade = myContext.Grades.Find(TraineeVM.Grade);
            var batchclass = myContext.BatchClasses.Find(TraineeVM.BatchClass);
            var push = new Trainee(TraineeVM, grade, batchclass);
            myContext.Trainees.Add(push);
            result = myContext.SaveChanges();
            return result;
        }

        public int Delete(int id)
        {
            var delete = myContext.Trainees.Find(id);
            if (delete != null)
            {
                delete.Delete();
                return myContext.SaveChanges();
            }
            return 0;
        }

        public IEnumerable<Trainee> Get()
        {
            return myContext.Trainees.Include(trainee => trainee.BatchClass).ThenInclude(batchclass => batchclass.Batch).Include(trainee => trainee.BatchClass).ThenInclude(batchclass => batchclass.Class).Include(trainee => trainee.BatchClass).ThenInclude(batchclass => batchclass.Trainer).Include(trainee => trainee.Grade).Include(trainee => trainee.Employee).OrderByDescending(trainee=>trainee.Id).ToList();
        }

        public Trainee Get(int id)
        {
            return myContext.Trainees.Include(trainee => trainee.BatchClass).ThenInclude(batchclass => batchclass.Batch).Include(trainee => trainee.BatchClass).ThenInclude(batchclass => batchclass.Class).Include(trainee => trainee.BatchClass).ThenInclude(batchclass => batchclass.Trainer).Include(trainee => trainee.Grade).Include(trainee => trainee.Employee).FirstOrDefault(t=>t.Id==id);
        }

        public Trainee Get(TraineeVM TraineeVM)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Trainee> GetByTrainer(int trainerId)
        {
            return myContext.Trainees.Include(trainee => trainee.BatchClass).ThenInclude(batchclass => batchclass.Batch).Include(trainee => trainee.BatchClass).ThenInclude(batchclass => batchclass.Class).Include(trainee => trainee.BatchClass).ThenInclude(batchclass => batchclass.Trainer).Include(trainee => trainee.Grade).Include(trainee=>trainee.Employee).Where(trainee => trainee.BatchClass.Trainer.Id == trainerId).OrderByDescending(trainee => trainee.Id).ToList();
        }

        public IEnumerable<Trainee> GetByBatch(int batchId)
        {
            return myContext.Trainees.Include(trainee => trainee.BatchClass).ThenInclude(batchclass => batchclass.Batch).Include(trainee => trainee.BatchClass).ThenInclude(batchclass => batchclass.Class).Include(trainee => trainee.BatchClass).ThenInclude(batchclass => batchclass.Trainer).Include(trainee => trainee.Grade).Include(trainee => trainee.Employee).Where(trainee => trainee.BatchClass.Id == batchId).OrderByDescending(trainee => trainee.Id).ToList();
        }

        public int SubmitScore(int traineeId)
        {
            var traineeVM = new TraineeVM();
            //attitude trainees
            var attitudeTrainees = myContext.AttitudeTrainees.Include(attitude => attitude.Trainee).Include(attitude => attitude.Attitude).Where(at => at.Trainee.Id == traineeId).ToList();
            
            var attitudescore = 0;

            foreach (var data in attitudeTrainees)
            {
                attitudescore += (data.Value * data.Attitude.Weight) / 100;
            }

            var attitudetotal = attitudescore * 40 / 100;

            //coursecomprehension
            var courseComprehension = myContext.CourseComprehensionTrainees.Include(cc => cc.Trainee).Include(cc => cc.CourseComprehension).Where(cc => cc.Trainee.Id == traineeId).ToList();

            var ccscore = 0;

            foreach (var data in courseComprehension)
            {
                ccscore += (data.Value * data.CourseComprehension.Weight) / 100;
            }

            var cctotal = ccscore * 30 / 100;

            //final Project
            var finalproject = myContext.FinalProjectTrainees.Include(fp => fp.Trainee).Include(fp => fp.FinalProject).Where(at => at.Trainee.Id == traineeId).ToList();

            var fpscore = 0;

            foreach (var data in finalproject)
            {
                fpscore += (data.Value * data.FinalProject.Weight) / 100;
            }

            var fptotal = fpscore * 30 / 100;

            var total = attitudetotal +cctotal+ fptotal;

            var gradeA = myContext.Grades.Where(g => g.Name == "A").FirstOrDefault();
            var gradeB = myContext.Grades.Where(g => g.Name == "B").FirstOrDefault();

            var grades =0 ;
            if (total > gradeB.MaxValue)
            {
                 grades = gradeA.Id;
            }
            else
            {
                grades = gradeB.Id;
            }
            traineeVM.AttitudeScore = attitudescore;
            traineeVM.CourseScore = ccscore;
            traineeVM.ProjectScore = fpscore;
            traineeVM.TotalScore = total;
            var grade = myContext.Grades.Find(grades);
            var update = myContext.Trainees.Find(traineeId);
            update.Update(traineeId, traineeVM, grade);
            return myContext.SaveChanges();
            
        }

        public int Update(int id, TraineeVM TraineeVM)
        {
            var result = 0;
            var grade = myContext.Grades.Find(TraineeVM.Grade);
            var batchclass = myContext.BatchClasses.Find(TraineeVM.BatchClass);
            var update = myContext.Trainees.Find(id);
            update.Update(TraineeVM, grade, batchclass);
            result = myContext.SaveChanges();
            return result;
        }
    }
}
