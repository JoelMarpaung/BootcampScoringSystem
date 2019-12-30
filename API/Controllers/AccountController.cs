using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Services;
using API.Services.Interface;
using Data.Model;
using Data.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        IAccountServices accountservice = new AccountServices();

        [HttpGet]
        public IEnumerable<Account> Get()
        {
            //return new string[] { "value1", "value2" };
            return accountservice.Get();
        }
        [HttpGet("{id}", Name = "Get")]
        public string Get(string UName, string Pass)
        {
            return "Value";//accountservice.Get(UName, Pass);
        }

        [HttpPost]
        public Account Post(AccountVM accountVM)
        {
            return accountservice.Get(accountVM);
        }


    }
}
