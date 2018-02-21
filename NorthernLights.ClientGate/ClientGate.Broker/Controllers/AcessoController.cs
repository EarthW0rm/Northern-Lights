using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ClientGate.Broker.Controllers
{
    [Route("[controller]")]
    public class AcessoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}