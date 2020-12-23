using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class UniversityController : Controller
    {
        // GET: University

        private readonly UniversityService _universityService;

        public UniversityController()
        {
            _universityService = new UniversityService();
        }
        public ActionResult Index()
        {
            var universities = _universityService.GetUniversities();
            ViewBag.Universities = universities;
            return View();
        }

        [HttpGet]
        public ActionResult AddUni()
        {
            return View();
        }
        [HttpPost]
   //     public ActionResult AddUni(University university)
     //   {
       //     if (!ModelState.IsValid)
         //       return View(university);
        //}

        public ActionResult EditUni()
        {
            return View();
        }

        public ActionResult DeleteUni()
        {
            return RedirectToAction("Index");
        }
    }

}