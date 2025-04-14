using NtandoMabuthoStudyGroupP2.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace NtandoMabuthoStudyGroupP2.Controllers
{
    public class PeopleController : Controller
    {
        private static List<Student> studentList = new List<Student>();

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                studentList.Add(student);
                return RedirectToAction("StudentDisplay");
            }

            return View(student);
        }

       
        public ActionResult StudentDisplay()
        {
            return View(studentList);
        }
       
        
    }

}

