using Parcial2.Models;
using Parcial2.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Parcial2.Controllers
{
    public class EnrollementsController : Controller
    {
        EnrollementsRepository ErollementsObjeto = new EnrollementsRepository();
        Erollements erollements = new Erollements();
        [HttpGet]
        public ActionResult UnionDeTablas()
        {

            var join = ErollementsObjeto.UnionDeTablas();

            return View(join);
        }
    }
}
