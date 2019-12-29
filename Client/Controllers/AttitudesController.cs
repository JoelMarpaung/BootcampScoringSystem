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
    public class AttitudesController : Controller
    {
        string Baseurl = "https://localhost:44373/";
        readonly HttpClient client = new HttpClient();
        public AttitudesController()
        {
            //pasing service baseurl
            client.BaseAddress = new Uri(Baseurl);
            //clear default request header
            client.DefaultRequestHeaders.Clear();
            //define request data format
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        }
        // GET: Attitudes
        public ActionResult Index()
        {
            return View();
        }

        public async Task<JsonResult> List()
        {
            HttpResponseMessage Res = await client.GetAsync("api/Attitude");
            if (Res.IsSuccessStatusCode)
            {
                var service = await Res.Content.ReadAsAsync<Attitude[]>();

                //Deserializing the response received from web api 
                var json = JsonConvert.SerializeObject(service, Formatting.None, new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                });
                return Json(json);
            }
            return Json("Failed");
        }

        public JsonResult Add(AttitudeVM attitude)
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri(Baseurl)
            };
            var myContent = JsonConvert.SerializeObject(attitude);
            var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var result = client.PostAsync("api/Attitude/", byteContent).Result;

            return Json(result);
        }

        public JsonResult Update(int id, AttitudeVM attitude)
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri(Baseurl)
            };
            var myContent = JsonConvert.SerializeObject(attitude);
            var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var result = client.PutAsync("api/Attitude/" + id, byteContent).Result;
            return Json(result);

        }

        public JsonResult LoadAttitude()
        {
            IEnumerable<Attitude> attitude = null;

            var client = new HttpClient
            {
                BaseAddress = new Uri(Baseurl)
            };
            var responseTask = client.GetAsync("api/Attitude");
            responseTask.Wait();
            var result = responseTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<IList<Attitude>>();
                readTask.Wait();
                attitude = readTask.Result;
            }
            else
            {
                attitude = Enumerable.Empty<Attitude>();
                ModelState.AddModelError(string.Empty, "Server error try after some time.");
            }
            return Json(attitude);
        }

        public async Task<JsonResult> GetbyID(int id)
        {
            HttpResponseMessage response = await client.GetAsync("api/Attitude");
            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsAsync<Attitude[]>();
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
            var result = client.DeleteAsync("api/Attitude/" + id).Result;
            return Json(result);
        }


        // GET: Attitudes/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Attitudes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Attitudes/Create
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

        // GET: Attitudes/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Attitudes/Edit/5
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
        
    }
}