using NtandoMabuthoStudyGroupP2.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace NtandoMabuthoStudyGroupP2.Controllers
{
    public class PeopleController : Controller
    {
        // Simulated database list of students
        private static List<Student> studentList = new List<Student>();

        // GET: People/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: People/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                // Add student to the list
                studentList.Add(student);

                // Redirect to display view
                return RedirectToAction("StudentDisplay");
            }

            return View(student);
        }

        // GET: People/StudentDisplay
        public ActionResult StudentDisplay()
        {
            return View(studentList);
        }
    }
}
