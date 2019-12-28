using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Data.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Client.Controllers
{
    public class TraineesController : Controller
    {
        readonly HttpClient client = new HttpClient();
        public TraineesController()
        {
            client.BaseAddress = new Uri("https://localhost:44373/api/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        // GET: Trainees
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult BatchByTrainerList(int id)
        {
            var response = client.GetAsync("BatchClass/GetByTrainer/" + id);
            response.Wait();
            var result = response.Result;
            if (result.IsSuccessStatusCode)
            {
                var data = result.Content.ReadAsAsync<IList<BatchClass>>();
                data.Wait();
                var json = data.Result;
                return Json(json);
            }
            return Json("Internal Server Error");
        }

        public JsonResult TraineeByTrainerList(int id)
        {
            var response = client.GetAsync("Trainee/GetByTrainer/" + id);
            response.Wait();
            var result = response.Result;
            if (result.IsSuccessStatusCode)
            {
                var data = result.Content.ReadAsAsync<IList<Trainee>>();
                data.Wait();
                var json = data.Result;
                return Json(json);
            }
            return Json("Internal Server Error");
        }

    }
}