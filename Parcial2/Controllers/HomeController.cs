using Parcial2.Models;
using Parcial2.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Parcial2.Controllers
{
    public class HomeController : Controller
    {
        CoursesRepository coursesRepository = new CoursesRepository();
        Courses courses = new Courses();

        StudentsRepository studentsRepository = new StudentsRepository();

        //''''''''''''''''''''''''''''''''''''''''''''''''''
        EnrollementsRepository ErollementsObjeto = new EnrollementsRepository();
        Erollements erollements = new Erollements();

    }
}