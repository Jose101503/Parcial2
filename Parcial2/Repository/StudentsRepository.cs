using Parcial2.Models;
using Parcial2.Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Parcial2.Repository
{
    public class StudentsRepository : IStudents
    {
        EscuelaDeConexionesEntities bd = new EscuelaDeConexionesEntities();



        public List<Students> ListOfStudents()
        {
            var listadoestudiantes = bd.Students.ToList();

            return listadoestudiantes;

        }




    }
}