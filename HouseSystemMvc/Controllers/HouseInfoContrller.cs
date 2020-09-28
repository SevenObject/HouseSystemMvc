using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HouseSystemMvc.Controllers
{
    public class HouseInfoContrller : Controller
    {
        public IActionResult ShouHouseInfo()
        {
            return View(); 
        }
        public IActionResult UpdateHouseInfo(int ids)
        {
            ViewBag.ids = ids;
            return View();
        }
        public IActionResult AddHouseInfo()
        {
            return View();
        }
        public IActionResult SeleHoutypes(int ids)
        {
            ViewBag.ss = ids;
            return View();
        }
    }
}
