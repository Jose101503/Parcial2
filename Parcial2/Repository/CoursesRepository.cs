using Parcial2.Models;
using Parcial2.Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Parcial2.Repository
{
    public class CoursesRepository : ICourses
    {
        EscuelaDeConexionesEntities bd = new EscuelaDeConexionesEntities();

        public void Create(Courses c)
        {
            bd.Courses.Add(c);
            bd.SaveChanges();
        }
        public void Update(Courses c)
        {
            Courses datosaactualizar = new Courses();
            datosaactualizar = bd.Courses.Find(c.CouserId);
            datosaactualizar.Title = c.Title;
            bd.SaveChanges();
        }

        public void Delete(Courses c)
        {
            c = bd.Courses.Find(c.CouserId);
            _ = c;
            bd.Courses.Remove(c);
            bd.SaveChanges();
        }

        public List<Courses> ListDataCourses()
        {
            var ListOfDataOfCourse = bd.Courses.ToList();

            return ListOfDataOfCourse;
        }

        void ICourses.Update(Courses c)
        {
            throw new NotImplementedException();
        }
    }
}