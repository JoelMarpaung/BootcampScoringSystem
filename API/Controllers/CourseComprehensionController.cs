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
    public class CourseComprehensionController : ControllerBase
    {
        ICourseComprehensionServices courseComprehensionServices = new CourseComprehensionServices();
        // GET: api/Attitude
        [HttpGet]
        public ActionResult Get()
        {
            var get = courseComprehensionServices.Get();
            if (get != null)
            {
                return Ok(get);
            }
            return NotFound("No Data Found");//new string[] { "value1", "value2" };
        }

        // GET: api/Attitude/5
        [HttpGet("{id}")]
        public ActionResult<CourseComprehension> Get(int id)
        {
            var get = courseComprehensionServices.Get(id);
            if (get != null)
            {
                return Ok(get);
            }
            return NotFound("No Data Found");
        }

        [HttpGet("GetByClass/{classId}")]
        public ActionResult<CourseComprehension> GetByClass(int classId)
        {
            var get = courseComprehensionServices.GetByClass(classId);
            if (get != null)
            {
                return Ok(get);
            }
            return NotFound("No Data Found");
        }

        // POST: api/Attitude
        [HttpPost]
        public ActionResult Post(CourseComprehensionVM courseComprehensionVM)
        {
            if (ModelState.IsValid)
            {
                var push = courseComprehensionServices.Create(courseComprehensionVM);
                if (push != 0)
                {
                    return Ok("Successfully Insert");
                }
            }
            return StatusCode(500, "Insert Failed");
        }

        // PUT: api/Attitude/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, CourseComprehensionVM courseComprehensionVM)
        {
            if (ModelState.IsValid)
            {
                var push = courseComprehensionServices.Update(id, courseComprehensionVM);
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
                var push = courseComprehensionServices.Delete(id);
                if (push != 0)
                {
                    return Ok("Successfully Delete");
                }
            }
            return StatusCode(500, "Delete Failed");
        }
    }
}