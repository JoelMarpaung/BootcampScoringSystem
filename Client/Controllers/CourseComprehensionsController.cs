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
    public class CourseComprehensionsController : Controller
    {
        string Baseurl = "https://localhost:44373/";
        readonly HttpClient client = new HttpClient();

        public CourseComprehensionsController()
        {
            client.BaseAddress = new Uri(Baseurl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        // GET: CourseComprehensions
        public ActionResult Index()
        {
            return View(List());
        }


        public async Task<JsonResult> List()
        {
            HttpResponseMessage response = await client.GetAsync("API/CourseComprehension");
            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsAsync<CourseComprehension[]>();
                var json = JsonConvert.SerializeObject(data, Formatting.None, new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                });
                return Json(json);
            }
            return Json("Internal Server Error");
        }

        public JsonResult ClassList()
        {
            IEnumerable<Class> classes = null;
            var responseTask = client.GetAsync("API/Class");
            responseTask.Wait();

            var result = responseTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<IList<Class>>();
                readTask.Wait();
                classes = readTask.Result;
            }
            else
            {
                classes = Enumerable.Empty<Class>();
                ModelState.AddModelError(string.Empty, "Server error");
            }
            return Json(classes);
        }

        public JsonResult InsertOrUpdate(CourseComprehensionVM coursecomprehensionVM)
        {
            var myContent = JsonConvert.SerializeObject(coursecomprehensionVM);
            var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
            var byteContent = new ByteArrayContent(buffer);

            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            if (coursecomprehensionVM.Id == 0)
            {
                var result = client.PostAsync("API/CourseComprehension", byteContent).Result;
                return Json(result);
            }
            else
            {
                var result = client.PutAsync("API/CourseComprehension/" + coursecomprehensionVM.Id, byteContent).Result;
                return Json(result);
            }

        }
        //public async task<jsonresult> classlist()
        //{
        //    httpresponsemessage response = await client.getasync("api/class");
        //    if (response.issuccessstatuscode)
        //    {
        //        var data = await response.content.readasasync<class[]>();
        //        var json = jsonconvert.serializeobject(data, formatting.none, new jsonserializersettings()
        //        {
        //            referenceloophandling = newtonsoft.json.referenceloophandling.ignore
        //        });
        //        return json(json);
        //    }
        //    return json("internal server error");
        //}

        // GET: CourseComprehensions/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CourseComprehensions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CourseComprehensions/Create
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

        // GET: CourseComprehensions/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CourseComprehensions/Edit/5
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

        public async Task<JsonResult> GetbyId(int id) //Update row
        {
            HttpResponseMessage response = await client.GetAsync("API/CourseComprehension");
            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsAsync<IList<CourseComprehension>>();
                var item = data.FirstOrDefault(i => i.Id == id);
                var json = JsonConvert.SerializeObject(item, Formatting.None, new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                });
                return Json(json);
            }
            return Json("Internal Server Error");
        }



        // GET: CourseComprehensions/Delete/5
        public JsonResult Delete(int id)
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri(Baseurl)
            };
            var result = client.DeleteAsync("API/CourseComprehension/" + id).Result;
            return Json(result);
        }

        // POST: CourseComprehensions/Delete/5
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