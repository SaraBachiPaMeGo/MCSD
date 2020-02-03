using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccesoDatosCore.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AccesoDatosCore.Controllers
{
    public class DepartamentosController : Controller
    {
        IRepository repo;
        public DepartamentosController(IRepository repo) 
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            return View(repo.GetDepartamentos());
        }
    }
}