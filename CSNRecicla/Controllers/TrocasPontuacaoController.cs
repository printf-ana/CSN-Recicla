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
    public class TrocasPontuacaoController : Controller
    {
        private readonly ApplicationDbContext DbContext;
        private readonly UserManager<Usuario> UserManager;

        public TrocasPontuacaoController(ApplicationDbContext dbContext, UserManager<Usuario> userManager)
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

        public IActionResult Status()
        {
            return View();
        }
    }
}
