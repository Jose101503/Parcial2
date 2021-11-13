using Parcial2.Servicio;
using Parcial2.Models;
using Parcial2.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Parcial2.Controllers
{
    public class RegistroController : Controller
    {
        CoursesRepository coursesRepository = new CoursesRepository();
        Courses courses = new Courses();
        [HttpGet]
        public ActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registrar(Courses cursos)
        {
            coursesRepository.Create(cursos);
            //_ = courses;
            return View();
        }
        [HttpGet]
        public ActionResult ServicioDelete()
        {
            return View();
        }
        //ServicioDelete
        [HttpPost]
        public ActionResult ServicioDelete(Courses cursos)
        {
            try
            {
                courses.CouserId = 1;
                coursesRepository.Delete(cursos);
            }
            catch
            {
                return Redirect("Error");
            }
            return View();
        }

        public ActionResult Error()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

    }
}