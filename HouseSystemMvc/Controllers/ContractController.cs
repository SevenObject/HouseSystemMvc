using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using HouseSystemMvc.Views;
using HouseSystemMvc.Views.Contract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Session;

namespace HouseSystemMvc.Controllers
{
    public class ContractController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public ActionResult CheckCode()
        {
            //生成验证码
            ValidateCode validateCode = new ValidateCode();
            string code = validateCode.CreateValidateCode(4);
            //HttpContext.Session.SetString("code", code);
            byte[] bytes = validateCode.CreateValidateGraphic(code);
            return File(bytes, @"image/jpeg");
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
