using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Data.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Client.Controllers
{
    public class AttitudeTraineesController : Controller
    {
        readonly HttpClient client = new HttpClient();
        public AttitudeTraineesController()
        {
            client.BaseAddress = new Uri("https://localhost:44373/api/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult InsertOrUpdate(AttitudeTraineeVM attitudeTraineeVM)
        {
            var myContent = JsonConvert.SerializeObject(attitudeTraineeVM);
            var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            if (attitudeTraineeVM.Id.Equals(0))
            {
                var result = client.PostAsync("AttitudeTrainee", byteContent).Result;
                return Json(result);
            }
            else
            {
                var result = client.PutAsync("AttitudeTrainee/" + attitudeTraineeVM.Id, byteContent).Result;
                return Json(result);
            }
        }
    }
}