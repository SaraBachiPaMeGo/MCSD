using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalCore.Models;
using HospitalCore.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HospitalCore.Controllers
{
    public class HospitalesController : Controller
    {
        IRepository repo;
        public HospitalesController(IRepository repo)
        { 
             this.repo=repo;
        }
        public IActionResult Index()
        {
            return View(repo.GetHospitales());
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Hospital hospi)
        {
            repo.InsertarHospi(hospi);
            return RedirectToAction("Index");
        }
    }
}