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
    public class GradesController : Controller
    {
        string Baseurl = "https://localhost:44373/";
        readonly HttpClient client = new HttpClient();
        public GradesController()
        {
            //pasing service baseurl
            client.BaseAddress = new Uri(Baseurl);
            //clear default request header
            client.DefaultRequestHeaders.Clear();
            //define request data format
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        }
        // GET: Grades
        public ActionResult Index()
        {
            return View();
        }
        public async Task<JsonResult> List()
        {
            HttpResponseMessage Res = await client.GetAsync("api/Grade");
            if (Res.IsSuccessStatusCode)
            {
                var service = await Res.Content.ReadAsAsync<Grade[]>();

                //Deserializing the response received from web api 
                var json = JsonConvert.SerializeObject(service, Formatting.None, new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                });
                return Json(json);
            }
            return Json("Failed");
        }
        public JsonResult Add(GradeVM grade)
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri(Baseurl)
            };
            var myContent = JsonConvert.SerializeObject(grade);
            var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var result = client.PostAsync("api/Grade/", byteContent).Result;

            return Json(result);
        }

        public JsonResult Update(int id, GradeVM grade)
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri(Baseurl)
            };
            var myContent = JsonConvert.SerializeObject(grade);
            var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var result = client.PutAsync("api/Grade/" + id, byteContent).Result;
            return Json(result);

        }

        public async Task<JsonResult> GetbyID(int id)
        {
            HttpResponseMessage response = await client.GetAsync("api/Grade");
            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsAsync<Grade[]>();
                var attitude = data.FirstOrDefault(s => s.Id == id);
                var json = JsonConvert.SerializeObject(attitude, Formatting.None, new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
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
            var result = client.DeleteAsync("api/Grade/" + id).Result;
            return Json(result);
        }
        // GET: Grades/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Grades/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Grades/Create
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

        // GET: Grades/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Grades/Edit/5
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
        
        // POST: Grades/Delete/5
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