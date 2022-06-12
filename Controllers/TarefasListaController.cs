using Microsoft.AspNetCore.Mvc;
using PraHoje.DTOs;
using PraHoje.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PraHoje.Controllers
{
    public class TarefasListaController : Controller
    {
        private readonly ITarefasListaService service;

        public TarefasListaController(ITarefasListaService service)
        {
            this.service = service;
        }

        public async Task<IActionResult> Index()
        {
            var list = await service.GetAllAsync();
            return Json(new { success = true, list });
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(string descricao)
        {           
            if (string.IsNullOrEmpty(descricao))
            {
                return Json(new { success = false });
            }
            else
            {
                var tarefas = await service.AdicionarTarefa(descricao);
                return Json(new { success = true, tarefas });
            }
        }

        [HttpPost]

        public async Task<IActionResult> Update(Guid id)
        {
            await service.UpdateAsync(id);
            return Json(new { success = true });
        }

        public async Task<IActionResult> Details(Guid id)
        {
            await service.GetByIdAsync(id);
            return View();
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            await service.GetByIdAsync(id);
            return Json(new { success = true });
        }

    }
}
