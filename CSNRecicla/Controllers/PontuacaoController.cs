using CSNRecicla.Data;
using CSNRecicla.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSNRecicla.Controllers
{
    [Authorize]
    public class PontuacaoController : Controller
    {
        private readonly ApplicationDbContext DbContext;
        private readonly UserManager<Usuario> UserManager;

        public PontuacaoController(ApplicationDbContext dbContext, UserManager<Usuario> userManager)
        {
            DbContext = dbContext;
            UserManager = userManager;
        }

        public IActionResult Index()
        {
            PontuacaoViewModel pontuacao = new PontuacaoViewModel();
            pontuacao.Pontos = DbContext.Users
                .Where(u => u.Id == UserManager.GetUserId(User))
                .FirstOrDefault().Pontos;
            return View(pontuacao);
        }

        public IActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Registrar(RegistroDePontosViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var user = await DbContext.Users.FindAsync(UserManager.GetUserId(User));
                    user.Pontos = (model.Quantidade * 7) + user.Pontos;
                    DbContext.Attach(user);
                    DbContext.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View(model);
                }
            }
            return View(model);
        }
    }
}
