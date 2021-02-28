using CSNRecicla.Data;
using CSNRecicla.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSNRecicla.Controllers
{
    [Authorize]
    public class PontosDeColetaController : Controller
    {
        private readonly ApplicationDbContext DbContext;
        private readonly UserManager<Usuario> UserManager;
        public PontosDeColetaController(ApplicationDbContext dbContext, UserManager<Usuario> userManager)
        {
            DbContext = dbContext;
            UserManager = userManager;
        }
        // GET: PontosDeColetaController
        public IActionResult Index()
        {
            IEnumerable<PontoDeColeta> pontosDeColetas = DbContext
                .PontoDeColetas.Include(p => p.Usuario).Where(p => p.UsuarioId == UserManager.GetUserId(User));
            List<PontoDeColetaViewModel> pontosViewModel = new List<PontoDeColetaViewModel>();
            // TODO: utilizar AutoMapper
            foreach(var p in pontosDeColetas)
            {
                pontosViewModel.Add(new PontoDeColetaViewModel()
                {
                    Nome = p.Nome,
                    Descricao = p.Descricao,
                    CEP = p.CEP,
                    Endereco = $"{p.Numero}, {p.Logradouro}, {p.Cidade} - {p.Estado}",
                    NumeroDoc = p.Usuario.NumeroDoc
                });
            }
            return View(pontosViewModel);
        }

        // GET: PontosDeColetaController/Details/5
        public IActionResult Details(int id)
        {
            return View();
        }

        // GET: PontosDeColetaController/Create
        public IActionResult Cadastrar()
        {
            return View();
        }

        // POST: PontosDeColetaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Cadastrar(PontoDeColetaViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    PontoDeColeta pontoDeColeta = new PontoDeColeta()
                    {
                        CEP = model.CEP,
                        Cidade = model.Cidade,
                        Descricao = model.Descricao,
                        Estado = model.Estado,
                        Logradouro = model.Logradouro,
                        Nome = model.Nome,
                        Numero = model.Numero,
                        Pais = model.Pais,
                        Telefone = model.Telefone,
                        UsuarioId = UserManager.GetUserId(User)
                    };
                    DbContext.PontoDeColetas.Add(pontoDeColeta);
                    DbContext.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
                return View(model);
            }
            catch
            {
                return View(model);
            }
        }

        // GET: PontosDeColetaController/Edit/5
        public IActionResult Editar(int id)
        {
            return View();
        }

        // POST: PontosDeColetaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Editar(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PontosDeColetaController/Delete/5
        public IActionResult Excluir(int id)
        {
            return View();
        }

        // POST: PontosDeColetaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Excluir(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public IActionResult Encontrar()
        {
            return View();
        }
    }
}
