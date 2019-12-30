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
    public class MainController : Controller
    {
        readonly HttpClient client = new HttpClient();

        public MainController()
        {
            client.BaseAddress = new Uri("https://localhost:44373/api/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        // GET: Main
        public ActionResult Index()
        {
            var Id = HttpContext.Session.GetString("Id");
            if (Id != null)
            {
                return View();
            }
            return RedirectToAction(nameof(Login));
        }

        public ActionResult Login()
        {
            var Id = HttpContext.Session.GetString("Id");
            if (Id == null)
            {
                return View();
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(AccountVM accountVM)
        {
            try
            {
                // TODO: Add insert logic here
                var myContent = JsonConvert.SerializeObject(accountVM);
                var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
                var byteContent = new ByteArrayContent(buffer);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                var result = client.PostAsync("Account", byteContent).Result;
                if (result.IsSuccessStatusCode)
                {
                    var data = result.Content.ReadAsAsync<Account>();
                    data.Wait();
                    var user = data.Result;

                    if (user.Role.Id == 2)
                    {
                        var response = client.GetAsync("BatchClass/GetByTrainer/" + user.Id.ToString());
                        response.Wait();
                        var result2 = response.Result;
                        if (result2.IsSuccessStatusCode)
                        {
                            var data2 = result2.Content.ReadAsAsync<IList<BatchClass>>();
                            data2.Wait();
                            var json = data2.Result.FirstOrDefault();
                            HttpContext.Session.SetString("ClassId", json.Class.Id.ToString());
                        }
                    }
                    HttpContext.Session.SetString("Id", user.Id.ToString());
                    HttpContext.Session.SetString("Name", user.Employee.FirstName.ToString()+" "+ user.Employee.LastName.ToString());
                    HttpContext.Session.SetString("RoleId", user.Role.Id.ToString());
                    return RedirectToAction(nameof(Index));
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult Logout()
        {
            HttpContext.Session.Remove("Id");
            HttpContext.Session.Remove("Name");
            HttpContext.Session.Remove("RoleId");
            return RedirectToAction(nameof(Index));
        }

    }
}