using CSNRecicla.Data;
using CSNRecicla.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSNRecicla.Controllers
{
    public class AcessoController : Controller
    {
        private readonly UserManager<Usuario> UserManager;
        private readonly SignInManager<Usuario> SignInManager;
        private readonly ApplicationDbContext ApplicationDbContext;

        public AcessoController(UserManager<Usuario> userManager, SignInManager<Usuario> signInManager, ApplicationDbContext applicationDbContext)
        {
            UserManager = userManager;
            SignInManager = signInManager;
            ApplicationDbContext = applicationDbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginViewModel model)
        {
            var canSignIn = await SignInManager.CanSignInAsync(new Usuario() { UserName = model.Login, Email = model.Login });
            if (ModelState.IsValid && canSignIn) 
            {
                var res = await SignInManager.PasswordSignInAsync(model.Login, model.Senha, false, false);

                if (res.Succeeded)
                    return RedirectToAction("Index", "Pontuacao");
            }
            ViewBag.Message = "E-mail ou senha incorretos.";
            return View(model);
        }

        public IActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Registrar(RegistroViewModel model)
        {
            if (ModelState.IsValid)
            {
                Usuario usuario = new Usuario()
                {
                    PrimeiroNome = model.PrimeiroNome,
                    SegundoNome = model.UltimoNome,
                    Email = model.Email,
                    NumeroDoc = model.NumeroDoc,
                    UserName = model.Email
                };
                var res = await UserManager.CreateAsync(usuario, model.Senha);
                if(res.Succeeded)
                    return RedirectToAction("Index", "Acesso");
            }
            ViewBag.Message = "Formulário inválido. Lembre-se que a senha deve conter caracter especial, número e letra";
            return View(model);
        }
        public async Task<IActionResult> Logout()
        {
            await SignInManager.SignOutAsync();
            return RedirectToAction(nameof(Index), "Home");
        }
    }
}
