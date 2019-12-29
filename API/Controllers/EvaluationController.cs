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
    public class EvaluationController : ControllerBase
    {
        IEvaluationServices evaluationServices = new EvaluationServices();
        // GET: api/Evaluation
        [HttpGet]
        public ActionResult Get()
        {
            var get = evaluationServices.Get();
            if (get != null)
            {
                return Ok(get);
            }
            return NotFound("No Data Found");//new string[] { "value1", "value2" };
        }


        // GET: api/evaluation/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var get = evaluationServices.Get(id);
            if (get != null)
            {
                return Ok(get);
            }
            return NotFound("No Data Found");
        }

        // POST: api/evaluation
        [HttpPost]
        public ActionResult Post(EvaluationVM evaluationVM)
        {
            if (ModelState.IsValid)
            {
                var push = evaluationServices.Create(evaluationVM);
                if (push != 0)
                {
                    return Ok("Successfully Insert");
                }
            }
            return StatusCode(500, "Insert Failed");
        }

        // PUT: api/Evaluation/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, EvaluationVM evaluationVM)
        {
            if (ModelState.IsValid)
            {
                var push = evaluationServices.Update(id, evaluationVM);
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
                var push = evaluationServices.Delete(id);
                if (push != 0)
                {
                    return Ok("Successfully Delete");
                }
            }
            return StatusCode(500, "Delete Failed");
        }
    }
}
