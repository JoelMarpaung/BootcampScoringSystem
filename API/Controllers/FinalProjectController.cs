﻿using System;
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
    public class FinalProjectController : ControllerBase
    {
        IFinalProjectServices finalProjectServices = new FinalProjectServices();
        // GET: api/Attitude
        [HttpGet]
        public ActionResult Get()
        {
            var get = finalProjectServices.Get();
            if (get != null)
            {
                return Ok(get);
            }
            return NotFound("No Data Found");//new string[] { "value1", "value2" };
        }

        // GET: api/Attitude/5
        [HttpGet("{id}")]
        public ActionResult<FinalProject> Get(int id)
        {
            var get = finalProjectServices.Get(id);
            if (get != null)
            {
                return Ok(get);
            }
            return NotFound("No Data Found");
        }

        // POST: api/Attitude
        [HttpPost]
        public ActionResult Post(FinalProjectVM finalProjectVM)
        {
            if (ModelState.IsValid)
            {
                var push = finalProjectServices.Create(finalProjectVM);
                if (push != 0)
                {
                    return Ok("Successfully Insert");
                }
            }
            return StatusCode(500, "Insert Failed");
        }

        // PUT: api/Attitude/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, FinalProjectVM finalProjectVM)
        {
            if (ModelState.IsValid)
            {
                var push = finalProjectServices.Update(id, finalProjectVM);
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
                var push = finalProjectServices.Delete(id);
                if (push != 0)
                {
                    return Ok("Successfully Delete");
                }
            }
            return StatusCode(500, "Delete Failed");
        }
    }
}
