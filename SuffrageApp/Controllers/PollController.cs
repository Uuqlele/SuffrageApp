using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core;
using Core.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace SuffrageApp.Controllers
{
    public class PollController : Controller
    {
        private readonly IPollService _pollService;

        public PollController(IPollService pollService)
        {
            _pollService = pollService;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var polls = _pollService.GetAllPolls();

            return View(polls);
        }

        [HttpGet]
        public IActionResult PollView(int id)
        {
            var poll = _pollService.GetPoll(id);

            return View(poll);
        }

        [HttpGet]
        public IActionResult PollEdit(int id)
        {
            var poll = _pollService.GetPoll(id);

            return View(poll);
        }


        [HttpPost]
        public IActionResult PollEdit(PollDto dto)
        {
            _pollService.UpdatePoll(dto);

            return RedirectToAction("PollView", new { id = dto.Id });
        }
    }
}
