using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationBlazorDemo.Shared;

namespace WebApplicationBlazorDemo.Server.Controllers
{
    public class AccountController : BaseController
    {
        [HttpPost("[action]")]
        public UserLoginInputModel  Login([FromBody]UserLoginInputModel model)
        {
           
            return model;
        }
    }
}
