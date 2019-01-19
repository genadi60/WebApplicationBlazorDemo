using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationBlazorDemo.Server.Controllers
{
    [Route("api/[controller]")]
    public abstract class BaseController : Controller
    {
    }
}
