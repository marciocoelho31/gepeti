using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using gepeti.Models;
using gepeti.ViewModels;
using gepeti.Repositories;

namespace gepeti.Controllers
{
    public class HomeController : Controller
    {

        private readonly ICabRepository _cabRepository;

        public HomeController(ICabRepository cabRepository)
        {
            _cabRepository = cabRepository;
        }

        public IActionResult Index()
        {
            Cab cab = _cabRepository.LerDadosEmpresa();

            var homeViewModel = new HomeViewModel
            {
                Empresa = cab.Empresa,
                DadosContato = cab.DadosContato
            };

            return View(homeViewModel);
        }

        public IActionResult Login()
        {
            return View();
        }

    }
}
