using Microsoft.AspNetCore.Mvc;
using NerdStore.Catalogo.Application.Services;
using NerdStore.Catalogo.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.Controllers.Admin
{
    public class CategoriaController : Controller
    {
        private readonly ICategoriaAppService _categoriaAppService;

        public CategoriaController(ICategoriaAppService categoriaAppService)
        {
            _categoriaAppService = categoriaAppService;
        }

        [HttpGet]
        [Route("categorias")]
        public async  Task<IActionResult> Index()
        {
            return View(await _categoriaAppService.ObterTodos());
        }

        [Route("add-categoria")]
        public async Task<IActionResult> NovaCategoria()
        {
            return View();
        }

        [HttpPost]
        [Route("add-categoria")]
        public async Task<IActionResult> NovaCategoria(CategoriaViewModel categoriaViewModel)
        {
            if(!ModelState.IsValid) return View(categoriaViewModel);

            await _categoriaAppService.AdicionarCategoria(categoriaViewModel);

            return RedirectToAction("Index");
        }

        [Route("atualizar-categoria")]
        public async Task<IActionResult> AtualizarCategoria(Guid id)
        {
            return View(await _categoriaAppService.ObterPorId(id));
        }

        [HttpPost]
        [Route("atualizar-categoria")]
        public async Task<IActionResult> AtualizarCategoria(CategoriaViewModel categoriaViewModel)
        {
           if(!ModelState.IsValid) return View(categoriaViewModel); 
           
            await _categoriaAppService.AtualizarCategoria(categoriaViewModel);
            return RedirectToAction("Index");
        }

        [Route("remover-categoria")]
        public async Task<IActionResult> RemoverCategoria(Guid id)
        {
            return View(await _categoriaAppService.ObterPorId(id));
        }


        [HttpPost]
        [Route("remover-categoria")]
        public async Task<IActionResult> RemoverCategoria(CategoriaViewModel categoriaViewModel)
        {
            if (!ModelState.IsValid) return View(categoriaViewModel);

            await _categoriaAppService.RemoverCategoria(categoriaViewModel);
            return RedirectToAction("Index");
        }
    }
}
