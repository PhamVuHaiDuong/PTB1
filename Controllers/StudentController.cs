using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PTB1.Models;

namespace PTB1.Controllers
{
    public class StudentController : Controller
    {
        LTQLDbContext db = new LTQLDbContext();
        // GET: Student
        public ActionResult Index()
        {
            return View(db.Students.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Student st)
        {
        if (ModelState.IsValid)
            {
                db.Students.Add(st);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}