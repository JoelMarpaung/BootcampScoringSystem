using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Id;
using API.Services.Interface;
using Data.Model;
using Data.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        IEmployeeServices employeeServices = new EmployeeServices();
        // GET: api/Attitude
        [HttpGet]
        public ActionResult Get()
        {
            var get = employeeServices.Get();
            if (get != null)
            {
                return Ok(get);
            }
            return NotFound("No Data Found");//new string[] { "value1", "value2" };
        }

        // GET: api/Attitude/5
        [HttpGet("{id}")]
        public ActionResult<Employee> Get(int id)
        {
            var get = employeeServices.Get(id);
            if (get != null)
            {
                return Ok(get);
            }
            return NotFound("No Data Found");
        }
        
    }
}
