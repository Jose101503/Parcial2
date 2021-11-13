using Parcial2.Models;
using Parcial2.Servicio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Parcial2.Repository
{
    public class EnrollementsRepository : IEnrollement
    {
        EscuelaDeConexionesEntities bd = new EscuelaDeConexionesEntities();
        public List<Erollements> UnionDeTablas()
        {
            var ConsultaJoin = bd.Erollements.Include(e => e.Students).Include(c => c.Courses).ToList();

            return ConsultaJoin;
        }
    }
}