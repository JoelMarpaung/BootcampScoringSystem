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
    public class FinalProjectTraineesController : Controller
    {
        readonly HttpClient client = new HttpClient();
        public FinalProjectTraineesController()
        {
            client.BaseAddress = new Uri("https://localhost:44373/api/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult InsertOrUpdate(FinalProjectTraineeVM finalProjectTraineeVM)
        {
            var myContent = JsonConvert.SerializeObject(finalProjectTraineeVM);
            var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            if (finalProjectTraineeVM.Id.Equals(0))
            {
                var result = client.PostAsync("FinalProjectTrainee", byteContent).Result;
                return Json(result);
            }
            else
            {
                var result = client.PutAsync("FinalProjectTrainee/" + finalProjectTraineeVM.Id, byteContent).Result;
                return Json(result);
            }
        }
    }
}