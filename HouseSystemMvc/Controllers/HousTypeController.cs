using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HouseSystemMvc.Controllers
{
    public class HousTypeController : Controller
    {
        public IActionResult ShowHousType()
        {
            return View();
        }
        public IActionResult SeleHousType(int ids)
        {
            ViewBag.ss = ids;
            return View();
        }
    }
}
