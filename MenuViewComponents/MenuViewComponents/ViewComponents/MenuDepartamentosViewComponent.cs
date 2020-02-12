using MenuViewComponents.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuViewComponents.ViewComponents
{
    public class MenuDepartamentosViewComponent : ViewComponent
    {
        RepositoryDept repo;

        public MenuDepartamentosViewComponent(RepositoryDept repo)
        {
            this.repo = repo;
        }

        //Los métodos que vayamos a utilizar para
        //incrustar las vistas deben ser async y 
        //devolver task<OBJETO>

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(repo.GetDepartamentos());
        }
    }
}
