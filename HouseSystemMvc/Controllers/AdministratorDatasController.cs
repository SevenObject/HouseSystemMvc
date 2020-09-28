using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HouseSystemMvc.Controllers
{
    public class AdministratorDatasController : Controller
    {
        public IActionResult ShowAdministratorDatas()
        {
            return View();
        }
        public IActionResult AddAdministratorDatas()
        {
            return View();
        }
        public IActionResult UpdateAdministratorDatas(int ids)
        {
            ViewBag.ee = ids;
            return View();
        }
    }
}
