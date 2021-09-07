using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PTB1.Models;
namespace PTB1.Controllers
{
    public class PTB1Controller : Controller
    {
        GiaiPTB1 GiaiPT = new GiaiPTB1();

        // GET: PTB1
        public ActionResult PTB1()
        {
            return View();
        }
        [HttpPost]
        public ActionResult PTB1(string Gta, string Gtb)
        {
            //nha 2 gia tri tham so gui tu client va chuyen sang kieu double
            double SoA = Convert.ToDouble(Gta);
            double SoB = Convert.ToDouble(Gtb);
            //khai bao bien x
            //ke thua phuong thuc giaiphuong trinh
            double x = GiaiPT.GiaiPhuongTrinh(SoA, SoB);
            ViewBag.Giatrix = x;
            return View();

        }
    }
}