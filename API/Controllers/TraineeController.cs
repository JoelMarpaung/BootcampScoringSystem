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
    public class TraineeController : ControllerBase
    {
        ITraineeServices traineeServices = new TraineeServices();
        // GET: api/Attitude
        [HttpGet]
        public ActionResult Get()
        {
            var get = traineeServices.Get();
            if (get != null)
            {
                return Ok(get);
            }
            return NotFound("No Data Found");//new string[] { "value1", "value2" };
        }

        // GET: api/Attitude/5
        [HttpGet("{id}")]
        public ActionResult<Trainee> Get(int id)
        {
            var get = traineeServices.Get(id);
            if (get != null)
            {
                return Ok(get);
            }
            return NotFound("No Data Found");
        }

        [HttpGet("GetByTrainer/{trainerId}")]
        public ActionResult<Trainee> GetByTrainer(int trainerId)
        {
            var get = traineeServices.GetByTrainer(trainerId);
            if (get != null)
            {
                return Ok(get);
            }
            return NotFound("No Data Found");
        }

        [HttpGet("SubmitScore/{traineeId}")]
        public ActionResult SubmitScore(int traineeId)
        {
            var get = traineeServices.SubmitScore(traineeId);
            if (get != 0)
            {
                return Ok(get);
            }
            return NotFound("No Data Found");
        }


        [HttpGet("GetByBatch/{batchId}")]
        public ActionResult<Trainee> GetByBatch(int batchId)
        {
            var get = traineeServices.GetByBatch(batchId);
            if (get != null)
            {
                return Ok(get);
            }
            return NotFound("No Data Found");
        }

        // POST: api/Attitude
        [HttpPost]
        public ActionResult Post(TraineeVM traineeVM)
        {
            if (ModelState.IsValid)
            {
                var push = traineeServices.Create(traineeVM);
                if (push != 0)
                {
                    return Ok("Successfully Insert");
                }
            }
            return StatusCode(500, "Insert Failed");
        }

        // PUT: api/Attitude/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, TraineeVM traineeVM)
        {
            if (ModelState.IsValid)
            {
                var push = traineeServices.Update(id, traineeVM);
                if (push != 0)
                {
                    return Ok("Successfully Update");
                }
            }
            return StatusCode(500, "Update Failed");
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (ModelState.IsValid)
            {
                var push = traineeServices.Delete(id);
                if (push != 0)
                {
                    return Ok("Successfully Delete");
                }
            }
            return StatusCode(500, "Delete Failed");
        }
    }
}
