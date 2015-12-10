//X00098814 Adam McGivern http://ca3cloudservice.cloudapp.net/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebRole1.Models;

namespace WebRole1.Controllers
{
    public class LottoController : Controller
    {
        [HttpGet]
        public ActionResult Lottery()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Lottery(Lotto newDraw)
        {
            if (ModelState.IsValid)
            {
                return View(newDraw);
            }
            return View();
        }
    }
}