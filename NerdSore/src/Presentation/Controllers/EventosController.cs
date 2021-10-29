using Microsoft.AspNetCore.Mvc;
using NerdStore.Core.Data.EventSourcing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.Controllers
{
    public class EventosController : Controller
    {
        private readonly IEventSourceRepository _eventSourcingRepository;

        public EventosController(IEventSourceRepository eventSourcingRepository)
        {
            _eventSourcingRepository = eventSourcingRepository;
        }

        [HttpGet("eventos/{id:guid}")]
        public async Task<IActionResult> Index(Guid id)
        {
            var eventos = await _eventSourcingRepository.ObterEventos(id);
            return View(eventos);
        }
    }
}
