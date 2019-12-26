using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Client.Controllers
{
    public class TraineesController : Controller
    {
        // GET: Trainees
        public ActionResult Index()
        {
            return View();
        }
        
    }
}