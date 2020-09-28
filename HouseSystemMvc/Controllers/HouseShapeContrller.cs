using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HouseSystemMvc.Controllers
{
    public class HouseShapeContrller : Controller
    {
        public IActionResult ShowHouseShape()
        {
            return View();
        }
        public IActionResult AddHouseShape()
        {
            return View();
        }
        public IActionResult UpdateHouseShape(int ids)
        {
            ViewBag.ss = ids;
            return View();
        }
    }
}
