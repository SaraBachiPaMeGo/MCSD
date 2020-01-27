using ServicioApiDoctor.Models;
using ServicioApiDoctor.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServicioApiDoctor.Controllers
{
    public class DoctorController : ApiController
    {
        RepositoryDoctor repo;

        public DoctorController()
        {
            this.repo = new RepositoryDoctor();
        }
        //Get: api/Doctores
        public List<Doctor> GetDoctores()
        {
            return repo.GetDoctores();
        }

        //Get: api/Doctores

        public Doctor GetUnDoctor(int id)
        {
            return repo.BuscarDoctor(id);
        }
    }
}
