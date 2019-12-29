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
    public class FinalProjectsController : Controller
    {
        string Baseurl = "https://localhost:44373/";
        readonly HttpClient client = new HttpClient();

        public FinalProjectsController()
        {
            client.BaseAddress = new Uri(Baseurl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        // GET: FinalProjects
        public ActionResult Index()
        {
            return View(List());
        }

        public async Task<JsonResult> List()
        {
            HttpResponseMessage response = await client.GetAsync("API/FinalProject");
            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsAsync<FinalProject[]>();
                var json = JsonConvert.SerializeObject(data, Formatting.None, new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                });
                return Json(json);
            }
            return Json("Internal Server Error");
        }

        public async Task<JsonResult> GetbyId(int id) //Update row
        {
            HttpResponseMessage response = await client.GetAsync("API/FinalProject");
            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsAsync<IList<FinalProject>>();
                var item = data.FirstOrDefault(i => i.Id == id);
                var json = JsonConvert.SerializeObject(item, Formatting.None, new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                });
                return Json(json);
            }
            return Json("Internal Server Error");
        }


        // GET: FinalProjects/Delete/5
        public JsonResult Delete(int id)
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri(Baseurl)
            };
            var result = client.DeleteAsync("API/FinalProject/" + id).Result;
            return Json(result);
        }

        public JsonResult InsertOrUpdate(FinalProjectVM finalprojectVM)
        {
            var myContent = JsonConvert.SerializeObject(finalprojectVM);
            var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            if (finalprojectVM.Id.Equals(0))
            {
                var result = client.PostAsync("API/FinalProject", byteContent).Result;
                return Json(result);
            }
            else
            {
                var result = client.PutAsync("API/FinalProject/" + finalprojectVM.Id, byteContent).Result;
                return Json(result);
            }
        }

        // GET: FinalProjects/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FinalProjects/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FinalProjects/Create
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

        // GET: FinalProjects/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FinalProjects/Edit/5
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


        // POST: FinalProjects/Delete/5
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