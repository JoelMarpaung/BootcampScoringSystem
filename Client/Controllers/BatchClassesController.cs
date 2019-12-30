using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Data.Model;
using Data.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Client.Controllers
{
    public class BatchClassesController : Controller
    {
        string Baseurl = "https://localhost:44373/";
        readonly HttpClient client = new HttpClient();
        public BatchClassesController()
        {
            //pasing service baseurl
            client.BaseAddress = new Uri(Baseurl);
            //clear default request header
            client.DefaultRequestHeaders.Clear();
            //define request data format
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        }

        // GET: BatchClasses
        public ActionResult Index()
        {
            return View();
        }

        public async Task<JsonResult> List()
        {
            HttpResponseMessage Res = await client.GetAsync("api/BatchClass");
            if (Res.IsSuccessStatusCode)
            {
                var service = await Res.Content.ReadAsAsync<BatchClass[]>();

                //Deserializing the response received from web api 
                var json = JsonConvert.SerializeObject(service, Formatting.None, new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                });
                return Json(json);
            }
            return Json("Failed");
        }
        // GET: BatchClasses/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BatchClasses/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BatchClasses/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BatchClasses/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BatchClasses/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        
        // POST: BatchClasses/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}