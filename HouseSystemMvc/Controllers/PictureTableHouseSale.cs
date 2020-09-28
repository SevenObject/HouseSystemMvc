using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HouseSystemMvc.Controllers
{
    public class PictureTableHouseSale : Controller
    {
        public IActionResult WokkerSalePK()
        {
            return View();
        }
        public IActionResult HouseState()
        {
            return View();
        }

        public IActionResult HouseStateYuanPicture()
        {
            return View();
        }
    }
}
