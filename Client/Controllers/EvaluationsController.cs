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
    public class EvaluationsController : Controller
    {
        string Baseurl = "https://localhost:44373/";
        readonly HttpClient client = new HttpClient();
        public EvaluationsController()
        {
            //pasing service baseurl
            client.BaseAddress = new Uri(Baseurl);
            //clear default request header
            client.DefaultRequestHeaders.Clear();
            //define request data format
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        }
        // GET: Evaluations
        public ActionResult Index()
        {
            return View();
        }
        public async Task<JsonResult> List()
        {
            HttpResponseMessage Res = await client.GetAsync("api/Evaluation");
            if (Res.IsSuccessStatusCode)
            {
                var service = await Res.Content.ReadAsAsync<Evaluation[]>();

                //Deserializing the response received from web api 
                var json = JsonConvert.SerializeObject(service, Formatting.None, new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                });
                return Json(json);
            }
            return Json("Failed");
        }

        public JsonResult Add(EvaluationVM attitude)
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri(Baseurl)
            };
            var myContent = JsonConvert.SerializeObject(attitude);
            var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var result = client.PostAsync("api/Evaluation/", byteContent).Result;

            return Json(result);
        }

        public JsonResult Update(int id, EvaluationVM attitude)
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri(Baseurl)
            };
            var myContent = JsonConvert.SerializeObject(attitude);
            var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var result = client.PutAsync("api/Evaluation/" + id, byteContent).Result;
            return Json(result);

        }
        
        public async Task<JsonResult> GetbyID(int id)
        {
            HttpResponseMessage response = await client.GetAsync("api/Evaluation");
            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsAsync<Evaluation[]>();
                var attitude = data.FirstOrDefault(s => s.Id == id);
                var json = JsonConvert.SerializeObject(attitude, Formatting.None, new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                });

                return Json(json);
            }
            return Json("Internal Server Error");
        }

        public JsonResult Delete(int id)
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri(Baseurl)
            };
            var result = client.DeleteAsync("api/Evaluation/" + id).Result;
            return Json(result);
        }
        // GET: Evaluations/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Evaluations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Evaluations/Create
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

        // GET: Evaluations/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Evaluations/Edit/5
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
        
        // POST: Evaluations/Delete/5
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