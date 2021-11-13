using Parcial2.Models;
using Parcial2.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Parcial2.Servicio;

namespace Parcial2.Controllers
{
    public class IndexController : Controller
    {
        CoursesRepository coursesRepository = new CoursesRepository();
        Courses courses = new Courses();

        StudentsRepository studentsRepository = new StudentsRepository();

        // GET: Index 
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Combobox()
        {
            var informationofStudents = studentsRepository.ListOfStudents();
            var informationofCourse = coursesRepository.ListDataCourses();


            List<SelectListItem> ComboboxOfStudents = new List<SelectListItem>();
            List<SelectListItem> ComboboxOfCourses = new List<SelectListItem>();




            foreach (var iteracion in informationofStudents)
            {


                ComboboxOfStudents.Add(new SelectListItem


                {
                    Text = iteracion.FirstMidName,
                    Value = Convert.ToString(iteracion.StudentId)


                }




                    );


                ViewBag.listofstudentcombobox = ComboboxOfStudents;


            }




            foreach (var iteracion in informationofCourse)
            {


                ComboboxOfCourses.Add(new SelectListItem


                {
                    Text = iteracion.Title,
                    Value = Convert.ToString(iteracion.CouserId)
                }




      );


                ViewBag.listofcoursescombobox = ComboboxOfCourses;


            }


            return View();

        }

        [HttpPost]
        public ActionResult getcombo(Erollements e)
        {
            _ = e;
            return View("Combobox");
        }

    }
}