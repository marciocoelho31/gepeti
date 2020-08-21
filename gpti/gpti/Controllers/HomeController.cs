using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using gpti.Models;
using gpti.ViewModels;
using gpti.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace gpti.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly ICabRepository _cabRepository;

        public HomeController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, ICabRepository cabRepository)
        {
            _cabRepository = cabRepository;
            _userManager = userManager;
            _signInManager = signInManager;
        }


        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login(string returnUrl)
        {
            return View(new LoginViewModel()
            {
                ReturnUrl = returnUrl
            });
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(loginViewModel);
            }

            // se eu entro na pagina de login com o mesmo username, ele trava no botao Entrar
            var user = await _userManager.FindByNameAsync(loginViewModel.UserName);

            if (user != null)
            {
                var result = await _signInManager.PasswordSignInAsync(user, loginViewModel.Password, false, false);

                if (result.Succeeded)
                {
                    if (string.IsNullOrEmpty(loginViewModel.ReturnUrl))
                    {
                        Cab cab = _cabRepository.LerDadosEmpresa();
                        var homeViewModel = new HomeViewModel
                        {
                            Empresa = cab.Empresa,
                            DadosContato = cab.DadosContato
                        };
                        return RedirectToAction("GPTI", "Home");
                    }
                    return RedirectToAction(loginViewModel.ReturnUrl);
                }
            }

            ModelState.AddModelError("CustomError", "Usuário/senha inválidos ou não localizados");
            return View(loginViewModel);
        }

        public IActionResult Index()
        {
            var loginViewModel = new LoginViewModel
            {

            };

            return View("Login", loginViewModel);
        }

        [Authorize]
        public IActionResult GPTI()
        {
            Cab cab = _cabRepository.LerDadosEmpresa();

            var homeViewModel = new HomeViewModel
            {
                Empresa = cab.Empresa,
                DadosContato = cab.DadosContato
            };

            return View("Index", homeViewModel);
        }

    }
}
