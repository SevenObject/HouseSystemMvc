using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using HouseSystemMvc.Views.Contract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HouseSystemMvc.Controllers
{
    public class ContractController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult ShowConList()
        {
            return View();
        }
        public IActionResult ShowCon()
        {
            return PartialView();
        }
        public IActionResult AddCon()
        {
            return View();
        }

    }
}
