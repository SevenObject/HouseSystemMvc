using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HouseSystemMvc.Controllers
{
    public class ClientDataController : Controller
    {
        public IActionResult ShowClientData()
        {
            return View();
        }
        public IActionResult AddClientData()
        {
            return View();
        }
    }
}
