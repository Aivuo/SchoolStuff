using SchoolStuff.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolStuff.Controllers
{
    public class HomeController : Controller
    {

        SchoolDb _db = new SchoolDb();
        // GET: Home
        public ActionResult Index()
        {
            var model = _db.Courses.ToList();

            return View(model);
        }

        public PartialViewResult CourseAssignments(int CourseId)
        {
            var model = _db.Courses.ToList();

            var model2 = model.Where(c => c.CourseId == CourseId).FirstOrDefault();

            var model3 = model2.CourseAssignments;

            return PartialView("_CourseAssignments", model3);
        }

        public PartialViewResult Students(int CourseId)
        {
            var model = _db.Courses.ToList();
            var model2 = model.Where(c => c.CourseId == CourseId).FirstOrDefault().CourseStudents;


            return PartialView("_Students", model2);
        }
    }
}