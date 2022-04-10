using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechAcadStudentsMVC.Models;

namespace TechAcadStudentsMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";


            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Page - The Tech Academy";

            return View();
        }
      
        public ActionResult Instructor(int id)
        {
            ViewBag.Id = id;

            List<Instructor > Instructors = new List<Instructor>
            {
               new Instructor
               {
                    Id = 1,
                    FirstName = "Erik",
                    LastName = "Gross"
               },
                new Instructor
               {
                    Id = 2,
                    FirstName = "Brett",
                    LastName = "Calendar"
               },
                 new Instructor
               {
                    Id = 3,
                    FirstName = "Adam",
                    LastName = "Smithsonian"
               }
            };
            return View(Instructors);
        }
        public ActionResult Instructors()
        {
            List<Instructor> Instructors = new List<Instructor>
            {
               new Instructor
               {
                    Id = 1,
                    FirstName = "Erik",
                    LastName = "Gross"
               },
                new Instructor
               {
                    Id = 2,
                    FirstName = "Brett",
                    LastName = "Calendar"
               },
                 new Instructor
               {
                    Id = 3,
                    FirstName = "Adam",
                    LastName = "Smithsonian"
               }
            };
            return View(Instructors);
            return View();
        }
    }
}