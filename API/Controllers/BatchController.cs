using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Services;
using API.Services.Interface;
using Data.Model;
using Data.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BatchController : ControllerBase
    {
        IBatchServices batchServices = new BatchServices();
        // GET: api/Attitude
        [HttpGet]
        public ActionResult Get()
        {
            var get = batchServices.Get();
            if (get != null)
            {
                return Ok(get);
            }
            return NotFound("No Data Found");//new string[] { "value1", "value2" };
        }

        // GET: api/Attitude/5
        [HttpGet("{id}")]
        public ActionResult<Batch> Get(int id)
        {
            var get = batchServices.Get(id);
            if (get != null)
            {
                return Ok(get);
            }
            return NotFound("No Data Found");
        }

    }
}
