﻿using API.Services.Interface;
using Data.Context;
using Data.Model;
using Data.Repositories;
using Data.Repositories.Interface;
using Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
    public class AttitudeEmployeeServices : IAttitudeEmployeeServices
    {
        int status = 0;
        private IAttitudeEmployeeRepository _AttitudeEmployeeRepository = new AttitudeEmployeeRepository();

        MyContext myContext = new MyContext();
        
        public int Create(AttitudeEmployeeVM attitudeEmployeeVM)
        {
            if (string.IsNullOrWhiteSpace(attitudeEmployeeVM.Value.ToString()))
            {
                return status;
            }
            else
            {
                return _AttitudeEmployeeRepository.Create(attitudeEmployeeVM);
            }
        }

        public int Delete(int id)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                return status;
            }
            else
            {
                return _AttitudeEmployeeRepository.Delete(id);
            }
        }

        public IEnumerable<AttitudeEmployee> Get()
        {
            return _AttitudeEmployeeRepository.Get();
        }

        public AttitudeEmployee Get(int id)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                var data = status;
            }
            return _AttitudeEmployeeRepository.Get(id);
        }

        public AttitudeEmployee Get(AttitudeEmployeeVM attitudeEmployeeVM)
        {
            if (string.IsNullOrWhiteSpace(attitudeEmployeeVM.Value.ToString()))
            {
                var data = status;
            }
            return _AttitudeEmployeeRepository.Get(attitudeEmployeeVM);
        }

        public int Update(int id, AttitudeEmployeeVM attitudeEmployeeVM)
        {
            if (string.IsNullOrWhiteSpace(attitudeEmployeeVM.Value.ToString()))
            {
                return status;
            }
            else
            {
                return _AttitudeEmployeeRepository.Update(id, attitudeEmployeeVM);
            }
        }
    }
}
