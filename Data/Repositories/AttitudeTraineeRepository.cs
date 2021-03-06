﻿using System;
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
    public class AttitudeTraineeRepository : IAttitudeTraineeRepository
    {
        MyContext myContext = new MyContext();

        public int Create(AttitudeTraineeVM AttitudeTraineeVM)
        {
            int result = 0;
            var trainee = myContext.Trainees.Find(AttitudeTraineeVM.Trainee);
            var attitude = myContext.Attitudes.Find(AttitudeTraineeVM.Attitude);
            var push = new AttitudeTrainee(AttitudeTraineeVM, trainee,attitude);
            myContext.AttitudeTrainees.Add(push);
            result = myContext.SaveChanges();
            return result;
        }

        public int Delete(int id)
        {
            var delete = myContext.AttitudeTrainees.Find(id);
            if (delete != null)
            {
                delete.Delete();
                return myContext.SaveChanges();
            }
            return 0;
        }

        public IEnumerable<AttitudeTrainee> Get()
        {
            return myContext.AttitudeTrainees.ToList();
        }

        public AttitudeTrainee Get(int id)
        {
            return myContext.AttitudeTrainees.Find(id);
        }

        public AttitudeTrainee Get(AttitudeTraineeVM AttitudeTraineeVM)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AttitudeTrainee> GetByTrainee(int traineeId)
        {
            return myContext.AttitudeTrainees.Include(a => a.Attitude).Include(a => a.Trainee).Where(a => a.Trainee.Id == traineeId).ToList();
        }

        public int Update(int id, AttitudeTraineeVM AttitudeTraineeVM)
        {
            var result = 0;
            var trainee = myContext.Trainees.Find(AttitudeTraineeVM.Trainee);
            var attitude = myContext.Attitudes.Find(AttitudeTraineeVM.Attitude);
            var update = myContext.AttitudeTrainees.Find(id);
            update.Update(AttitudeTraineeVM, trainee, attitude);
            result = myContext.SaveChanges();
            return result;
        }

    }
}
